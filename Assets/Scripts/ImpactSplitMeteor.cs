using UnityEngine;
using System.Collections;

public class ImpactSplitMeteor : MonoBehaviour
{
	public float speed;
	public GameObject[] smallPrefab;

	private GameObject smallMeteorIns;
	private Vector3 targetPosition;
	private bool isGoodToSeparate;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (smallMeteorIns != null) {
			smallMeteorIns.transform.position = Vector3.MoveTowards (transform.position, targetPosition, speed * Time.deltaTime);
		}
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Projectile") {
			for (int i = 0; i < smallPrefab.Length; i++) {
				smallMeteorIns = Instantiate (smallPrefab [i], transform.position, transform.rotation) as GameObject;
				targetPosition = new Vector3 (transform.position.x + Random.Range (-10, 10), transform.position.y + Random.Range (-10, 10), transform.position.z + Random.Range (-10, 10));
			}
			Destroy (gameObject);
		}
	}
}
