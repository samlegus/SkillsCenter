using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour 
{
	public int Damage = 10;
	public float Lifetime = 5f;

	// Use this for initialization
	void Start () 
	{
		//Destroy this object after a set amount of time.
		Destroy (gameObject, Lifetime);
	}

	//OnCollisionEnter2D is an event that is automatically called by Unity whenever two objects collide.
	//This even is automatically called, so we don't have to call it. Just like Start && Update
	void OnCollisionEnter2D(Collision2D col)
	{
		//Destroy the bullet (ourself) on impact, regardless if we dealt damage
		//or if our lifetime is up.
		Destroy (gameObject);
		Debug.Log ("Hit collider! Name is: " + col.gameObject.name);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		//Destroy (gameObject);
		Debug.Log ("Hit trigger! Name is: " + col.gameObject.name);
	}

}
