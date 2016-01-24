using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	
	public float damage = 5;
	public float moveSpeed = 5;
	public string name = "";
	
	public float getMovementSpeed()
	{
		return moveSpeed;
	}

	public float getDamage()
	{
		return damage;
	}

	public Weapon(float dmg, float speed, float name)
	{

	}
}
