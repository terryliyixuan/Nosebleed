using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class VRRecenter : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		InputTracking.Recenter ();
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			InputTracking.Recenter ();	
		}
	}

}
