using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveConfirmationText : MonoBehaviour
{

	public float speed;

	private RectTransform myRectTransform;

	// Use this for initialization
	void Start ()
	{
		myRectTransform = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (myRectTransform.transform.localPosition.y < 125) {
			transform.Translate (Vector3.up * speed * Time.deltaTime);
		}
	}
}
