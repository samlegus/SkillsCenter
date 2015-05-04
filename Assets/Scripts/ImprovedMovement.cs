using UnityEngine;
using System.Collections;

public class ImprovedMovement : MonoBehaviour 
{
	BoxCollider2D boxCollider;

	// Use this for initialization
	void Start () 
	{
		boxCollider = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float horizontalAxis = Input.GetAxisRaw ("Horizontal");
		float verticalAxis = Input.GetAxisRaw ("Vertical");

		RaycastHit2D boxHit;

		boxHit = Physics2D.BoxCast ( transform.position, boxCollider.size, 0, new Vector2(horizontalAxis, 0));

		if(boxHit.collider == null)
		{
			transform.Translate (horizontalAxis ,0, 0); 
		}

		boxHit = Physics2D.BoxCast ( transform.position, boxCollider.size, 0, new Vector2(0, verticalAxis));

		if(boxHit.collider == null)
		{
			transform.Translate (0, verticalAxis, 0 );
		}



	}
}
