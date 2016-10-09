using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour
{
	public float shakeToGive;

	private ShakeCamera cameraToShake;
	private AudioSource myAudioSource;

	// Use this for initialization
	void Start ()
	{
		cameraToShake = FindObjectOfType<ShakeCamera> ();
		myAudioSource = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Meteor") {
			cameraToShake.shake = shakeToGive;
			if (myAudioSource.isPlaying == false) {
				myAudioSource.Play ();
			}
			ManageGameState.currentState = 2;
		}
	}
}
