using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour 
{
	//Controls how fast our object will move
	public float Speed = 5.0f;

	// Update is called once per frame
	void Update () 
	{
		//Vector to store our movement value
		Vector3 movement = new Vector3(0f,0f,0f);

		if(Input.GetKey (KeyCode.D))
		{
			movement.x = Speed;
			movement.y = 0f;
		}

		transform.Translate ( movement * Time.deltaTime );
	}
}
