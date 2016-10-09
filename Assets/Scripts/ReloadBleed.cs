using UnityEngine;
using System.Collections;

public class ReloadBleed : MonoBehaviour
{

	private Ray playerRay;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		playerRay = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
		RaycastHit rayHitInfo = new RaycastHit ();
		if (Physics.Raycast (playerRay, out rayHitInfo, 1000f) && rayHitInfo.transform == this.transform) {
		
		}
	}
}
