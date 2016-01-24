using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Move : MonoBehaviour {

	private float speed;
	public Camera playerCamera;


	void Start()
	{
		//Cursor.visible = false;
	}

	void Awake()
	{
		speed = PlayerStats.getSpeed ();
	}

	// Update is called once per frame
	void Update () 
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		float mY = Input.GetAxis ("Mouse Y");
		float mX = Input.GetAxis ("Mouse X");

		CharacterController c = gameObject.GetComponent<CharacterController> ();

		c.SimpleMove(new Vector3(h * speed, 0, v * speed));

		transform.Rotate (new Vector3(0, (mX - mY) * speed, 0));


	}
}
