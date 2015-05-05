using UnityEngine;
using System.Collections;

public class CharacterHealth : MonoBehaviour 
{
	public int HP = 100;

	// Update is called once per frame
	void Update () 
	{
		//Destroy ourself if we're out of health!
		if( HP <= 0 )
		{
			Destroy(gameObject);
		}
	}

	// OnCollisionEnter2D is an event (like Start or Update) that is called
	// automatically by Unity. It's called when this objects Rigidbody2D hits
	// another objects BoxCollider2D ( or any other 2D collider ...  )
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.GetComponent<BulletBehaviour>() != null)
	   	{
			int damage = col.gameObject.GetComponent<BulletBehaviour>().Damage;
			HP -= damage;
		}
	}
}
