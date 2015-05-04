using UnityEngine;
using System.Collections;

public class ShootUpward : MonoBehaviour 
{
	Rigidbody2D myRigidbody;

	void Start()
	{
		myRigidbody = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		Vector3 force = transform.up * 10f;
		myRigidbody.AddForce( force );
	}

}
