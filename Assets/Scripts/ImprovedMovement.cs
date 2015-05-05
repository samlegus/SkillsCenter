using UnityEngine;
using System.Collections;

public class ImprovedMovement : MonoBehaviour 
{
	BoxCollider2D boxCollider;
	public float Speed = 5f;

	// Use this for initialization
	void Start () 
	{
		boxCollider = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float horizontalAxis = Input.GetAxisRaw ("Horizontal") * Speed * Time.deltaTime;
		float verticalAxis = Input.GetAxisRaw ("Vertical") * Speed * Time.deltaTime ;

		RaycastHit2D boxHit;

		boxHit = Physics2D.BoxCast ( transform.position, boxCollider.size, 0, new Vector2(horizontalAxis, 0), Mathf.Abs (horizontalAxis));

		if(boxHit.collider == null)
		{
			transform.Translate (horizontalAxis ,0f, 0f);
		}

		boxHit = Physics2D.BoxCast ( transform.position, boxCollider.size, 0, new Vector2(0, verticalAxis), Mathf.Abs(verticalAxis));

		if(boxHit.collider == null)
		{
			transform.Translate (0f, verticalAxis , 0f );
		}
	}
}
