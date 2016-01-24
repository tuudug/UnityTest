using UnityEngine;
using System.Collections;

public class NPCStats : MonoBehaviour {

	public static float movementSpeed = 5.0F;
	public static float health = 100.0F;
	
	void Update () {
		
	}
	
	public static float getSpeed()
	{
		return movementSpeed;
	}
	
	public static float getHealth()
	{
		return health;
	}
	
	public static void setSpeed(float newSpeed)
	{
		movementSpeed = newSpeed;
	}
	
	public static void setHealth(float newHealth)
	{
		health = newHealth;
	}
	
	public static void damage(float damageAmount)
	{
		health = health - damageAmount;
	}
}
