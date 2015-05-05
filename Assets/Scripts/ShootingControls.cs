using UnityEngine;
using System.Collections;

public class ShootingControls : MonoBehaviour 
{
	public GameObject BulletPrefab;		//We're gonna clone this. Add in the inspector.
	public float ShootingForce = 1000f;	//Determines how fast our bullet is gonna go.
	private Vector3 shootingDirection = Vector3.up; //The direction our bullet is gonna fly

	void Update()
	{
		//When the D key is held...
		if ( Input.GetKey ( KeyCode.W ) == true)
		{
			//Change our shooting direction to the left
			shootingDirection = Vector3.up;
		}
		if ( Input.GetKey ( KeyCode.S ) == true)
		{
			//Change our shooting direction to the left
			shootingDirection = Vector3.down;
		}
		if ( Input.GetKey ( KeyCode.A ) == true)
		{
			//Change our shooting direction to the left
			shootingDirection = Vector3.left;
		}
		if ( Input.GetKey ( KeyCode.D ) == true)
		{
			//Change our shooting direction to the left
			shootingDirection = Vector3.right;
		}
	
		//When we click the left mouse button
		if(Input.GetMouseButtonDown(0) == true )
		{
			//Clone our prefab, spawn it at our position & rotation
			GameObject bullet = Instantiate (BulletPrefab, 
			                                 transform.position, 
			                                 transform.rotation)
				as GameObject;

			//Make sure we don't collide with our bullets
			Physics2D.IgnoreCollision (bullet.GetComponent<BoxCollider2D>(),
			                           gameObject.GetComponent<BoxCollider2D>());
			//Use GetComponent<>() to extract the Bullet's Rigidbody
			Rigidbody2D bulletPhysics = bullet.GetComponent<Rigidbody2D>();
			bulletPhysics.AddForce ( shootingDirection * ShootingForce );
		}
	}
}
