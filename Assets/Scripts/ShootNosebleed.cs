using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShootNosebleed : MonoBehaviour
{
	// Public variables
	public GameObject bleedPrefab;
	public GameObject reloadObject;
	public GameObject heartPrefab;
	public float speed;
	public float cdTime;
	public float reloadTime;
	public int bleedAmount;


	// Public static variables
	public static float bleedCounter;

	// Private variables
	private float cdTimer;
	private GameObject bleedIns;
	private Vector3 shootRot;
	private Image aimImage;
	private Ray playerRay;
	private AudioSource[] myAudioSource;

	// Use this for initialization
	void Start ()
	{
		aimImage = GameObject.FindObjectOfType<Image> ();
		myAudioSource = GetComponents<AudioSource> ();
		cdTimer = reloadTime;
		bleedCounter = bleedAmount;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (ManageGameState.isGameStarted == true && ManageGameState.isGameEnded == false) {
			// Shoot the nosebleed
			cdTimer -= Time.deltaTime;
			if (cdTimer <= 0 && bleedCounter >= 1) {
				bleedIns = Instantiate (bleedPrefab, transform.position, transform.rotation) as GameObject;
				bleedIns.GetComponent<Rigidbody> ().velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
				myAudioSource [0].Play ();
				aimImage.fillAmount -= (float)1.0f / bleedAmount;
				bleedCounter--;
				cdTimer = cdTime;
			}
			Destroy (bleedIns, 5.0f);

			// Look at the date person to reload nosebleed
			playerRay = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
			RaycastHit rayHitInfo = new RaycastHit ();

			if (Physics.Raycast (playerRay, out rayHitInfo, 2000f) && rayHitInfo.transform == reloadObject.transform) {
				if (myAudioSource [1].isPlaying == false) {
					myAudioSource [1].Play ();
					Instantiate (heartPrefab, reloadObject.transform.position, reloadObject.transform.rotation);
				}
				bleedCounter = bleedAmount;
				aimImage.fillAmount = 1.0f;
				cdTimer = reloadTime;
			}
		}
	}
}
