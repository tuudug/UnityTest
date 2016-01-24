using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyAI : MonoBehaviour {

	public GameObject player;
	
	int i;
	Vector3[] rayDir = new Vector3[40];
	int count = -180;

	RaycastHit hit;

	void Awake()
	{
		/*for (i=0; i<19; i++) {
			rayDir[i] = Quaternion.AngleAxis(count, transform.up) * transform.forward * 3;
			count = count + 10;
		}
		for(i=20;i<37;i++)
		{
			rayDir[i] = Quaternion.AngleAxis(count, transform.up) * transform.forward * 3;
			count = count + 10;
		}*/
	}

	// Update is called once per frame
	void Update () 
	{
		//TODO ~ Track/Follow player/Wander
		/*
		for(i=0;i<37;i++)
		{
			if (Physics.Raycast(transform.position, rayDir[i], out hit)) 
			{
				if(hit.collider.name == "Player")
				{
					gameObject.GetComponent<NavMeshAgent> ().SetDestination (player.transform.position);
				}
			}
		}
		for(i=0;i<37;i++)
		{
			Debug.DrawRay(transform.position, rayDir[i]);
		}
		*/
	}
}
