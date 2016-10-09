using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
	public float speed = 10.0f;

	private Ray playerRay;
	private Image aimImage;

	// Use this for initialization
	void Start ()
	{
		aimImage = FindObjectOfType<Image> ();
		aimImage.fillAmount = 1.0f;
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
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
}
