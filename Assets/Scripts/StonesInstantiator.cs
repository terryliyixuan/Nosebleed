using UnityEngine;
using System.Collections;

public class StonesInstantiator : MonoBehaviour
{
	public GameObject[] meteors;
	private float xPos;
	private float yPos;
	private float zPos;
	public float delta;
	public float waitTime;
	private float waitTimer;

	// Use this for initialization
	void Start ()
	{
		waitTimer = waitTime;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (ManageGameState.isGameStarted == true && ManageGameState.isGameEnded == false) {
			waitTimer -= Time.deltaTime;
			if (waitTimer <= 0) {
				xPos = transform.position.x + Random.Range (-delta, delta);
				yPos = transform.position.y + Random.Range (-delta, delta);
				zPos = transform.position.z + Random.Range (-delta, delta);
				int rand = (int)Random.Range (0, meteors.Length);
				Instantiate (meteors [rand], new Vector3 (xPos, yPos, zPos), transform.rotation);
				waitTimer = waitTime;
			}
		}
	}
}
