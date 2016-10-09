using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
	public float speed;
	public GameObject[] textToDeactive;

	private Ray playerRay;
	private Image aimImage;

	// Use this for initialization
	void Start ()
	{
		aimImage = FindObjectOfType<Image> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		playerRay = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
		RaycastHit rayHitInfo = new RaycastHit ();

		if (Physics.Raycast (playerRay, out rayHitInfo, 2000f) && rayHitInfo.transform == this.transform) {
			aimImage.fillAmount -= Time.deltaTime * speed;
		}

		if (aimImage.fillAmount <= 0) {
			ManageGameState.currentState = 1;
			textToDeactive [0].SetActive (false);
			textToDeactive [1].SetActive (false);
			aimImage.fillAmount = 1;
		}
	}
}
