using UnityEngine;
using System.Collections;

public class UserControl : MonoBehaviour 
{
	public float Speed = 2.5f;			//How fast our normal speed is.
	
	// Update is called once per frame
	void Update () 
	{
		//Create new Vector to store our movement values.
		Vector3 movement = new Vector3(0f,0f,0f);
	
		//If the D key is held down...
		if(Input.GetKey (KeyCode.D) == true)
		{
			movement.x = Speed;			//Move our ship to the right.
			movement.y = 0f;
		}
		//If the A key is held down...
		if(Input.GetKey (KeyCode.A))
		{
			movement.x = -Speed;		//Move our ship to the left.
			movement.y = 0f;
		}
		if(Input.GetKey (KeyCode.W))
		{
			movement.x = 0f;
			movement.y = Speed;
		}
		if(Input.GetKey (KeyCode.S))
		{
			movement.x = 0f;
			movement.y = -Speed;
		}

		if (Input.GetKey (KeyCode.LeftShift))
	    {
			Speed = 10f;
		}
		else
		{
			Speed = 5f;
		}

		//Move our ship by whatever the end result of our move Vector was.
		//We multiply by deltaTime to make sure that our ship moves the same amount
		//no matter what computer its run on. (More on this later...)
		transform.Translate (movement * Time.deltaTime);
	}
}

