using UnityEngine;
using System.Collections;

public class ShootUpward : MonoBehaviour 
{
	//Store our Rigidbody2D in this variable
	Rigidbody2D myRigidbody;

	void Start()
	{
		//Use get component to access our Rigidbody2D
		myRigidbody = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		//Store the force we're going to push our object with
		Vector3 force = Vector3.up * 100f;
		myRigidbody.AddForce( force );
	}

}
