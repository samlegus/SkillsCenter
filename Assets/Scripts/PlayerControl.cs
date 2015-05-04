using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour 
{
	public float Speed = 5.0f;
	
	// Update is called once per frame
	void Update () 
	{
		// Create a vector to store our movement values
		Vector3 movement = new Vector3(0f,0f,0f);

		// When the D key is held, move to the right 
		if( Input.GetKey(KeyCode.D))
		{
			movement.x = Speed;
		}

		// Use transform.translate to move our object
		transform.Translate(movement * Time.deltaTime);
	}
}
