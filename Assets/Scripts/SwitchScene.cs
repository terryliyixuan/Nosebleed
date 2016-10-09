using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchScene : MonoBehaviour
{
	public string nextSceneName;
	public float speed;

	private Ray playerRay;
	public Image aimImage;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		playerRay = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
		RaycastHit rayHitInfo = new RaycastHit ();

		if (Physics.Raycast (playerRay, out rayHitInfo, 3000f) && rayHitInfo.transform == this.transform) {
			aimImage.fillAmount -= Time.deltaTime * speed;
		}
		

		if (aimImage.fillAmount <= 0) {
			SceneManager.LoadScene (nextSceneName);
		}
	}
}
