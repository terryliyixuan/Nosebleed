using UnityEngine;
using System.Collections;

public class ChangeCameraColor : MonoBehaviour
{
	public Color color1 = Color.black;
	public Color color2 = Color.red;
	public float duration = 3.0f;

	private Camera myCamera;



	// Use this for initialization
	void Start ()
	{
		myCamera = GetComponent<Camera> ();
		myCamera.clearFlags = CameraClearFlags.SolidColor;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (ManageGameState.currentState == 2) {
			float t = Mathf.PingPong (Time.time, duration) / duration;
			myCamera.backgroundColor = Color.Lerp (color1, color2, t);
		}
	}
}
