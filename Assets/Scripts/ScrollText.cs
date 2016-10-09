using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScrollText : MonoBehaviour
{
	// Public variables
	public float speed;
	public float heightToDisappear;

	// Private variables
	private RectTransform myRectTransform;

	// Use this for initialization
	void Start ()
	{
		myRectTransform = GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (Vector3.up * speed * Time.deltaTime);
		if (myRectTransform.position.y > heightToDisappear) {
			Destroy (gameObject);
		}
	}
}
