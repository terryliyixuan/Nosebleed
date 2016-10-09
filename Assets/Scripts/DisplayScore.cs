using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
	private Text myText;

	// Use this for initialization
	void Start ()
	{
		myText = GetComponent<Text> ();
		myText.text = CountScore.currentScore.ToString ();
	}

	void Update ()
	{

	}
}
