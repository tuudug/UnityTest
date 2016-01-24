using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	///public GameObject weapon;
	public float force = 5.0F;

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetMouseButtonDown(0)) 
		{
			//Debug.Log("pressed 0");
			GameObject b = 
				(GameObject)Instantiate(bullet, transform.position, transform.parent.rotation);
			b.GetComponent<Rigidbody>().AddForce(this.transform.forward * force);
		}
	}
}
