using UnityEngine;
using System.Collections;

public class ImpactRegularMeteor : MonoBehaviour
{
	public GameObject particle_Meteor;

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Projectile") {
			CountScore.currentScore++;
			Instantiate (particle_Meteor, transform.position, transform.rotation);
			Destroy (col.gameObject);
			Destroy (gameObject);
		}
	}
}
