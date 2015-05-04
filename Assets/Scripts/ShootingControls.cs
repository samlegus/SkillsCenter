using UnityEngine;
using System.Collections;

public class ShootingControls : MonoBehaviour 
{
	//This must be set from the inspector!
	public GameObject BulletPrefab;
	public float ShootingForce = 1000f;
	private Vector3 shootingDirection = Vector3.up;

	void Update()
	{
		if ( Input.GetKey ( KeyCode.D ) == true)
		{
			shootingDirection = Vector3.right;
		}

		//When we click the left mouse button
		if(Input.GetMouseButtonDown(0) == true )
		{
			GameObject bullet = Instantiate (BulletPrefab, 
			                                 transform.position, 
			                                 transform.rotation)
				as GameObject;

			Rigidbody2D bulletPhysics = bullet.GetComponent<Rigidbody2D>();
			bulletPhysics.AddForce ( shootingDirection * ShootingForce );
		}
	}
}
