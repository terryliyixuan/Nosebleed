using UnityEngine;
using System.Collections;

public class ImpactHeavyMeteor : MonoBehaviour
{

	public int health;
	public GameObject particlePrefab;

	private int currentHealth;

	// Use this for initialization
	void Start ()
	{
		currentHealth = health;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (currentHealth <= 0) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Projectile") {
			Destroy (col.gameObject);
			currentHealth--;
			Instantiate (particlePrefab, transform.position, transform.rotation);
		}
	}
}
