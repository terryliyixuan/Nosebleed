using UnityEngine;
using System.Collections;

public class MuteIntroAudio : MonoBehaviour
{
	private AudioSource myAudioSource;

	// Use this for initialization
	void Start ()
	{
		myAudioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (ManageGameState.isGameStarted == true) {
			myAudioSource.volume -= Time.deltaTime;
		}
	}
}
