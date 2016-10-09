using UnityEngine;
using System.Collections;

public class ManageGameState : MonoBehaviour
{

	public static int currentState;
	public static bool isGameStarted;
	public static bool isGameEnded;
	public float scrollSpeedToGive;
	public int stateToStart;
	public GameObject text_Fail;

	// Use this for initialization
	void Start ()
	{
		currentState = stateToStart;
		isGameStarted = false;
		isGameEnded = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		switch (currentState) {
		case 0:
//			scrollTextInScene.speed = scrollSpeedToGive;
//			moveTextInScene.speed = scrollSpeedToGive;
			break;
		case 1:
			isGameStarted = true;
			break;	
		case 2: 
			isGameEnded = true;
			text_Fail.SetActive (true);
			break;
		}
	}
}
