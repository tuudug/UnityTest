using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	public GameObject explosion;
	
	void OnCollisionEnter(Collision c)
	{
		Instantiate (explosion, gameObject.transform.position, Quaternion.identity);

		Destroy (gameObject);
	}
}
