using UnityEngine;
using System.Collections;

public class Flicker : MonoBehaviour 
{
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown (KeyCode.G) == true)
		{
			gameObject.GetComponent<SpriteRenderer>().enabled = false;
		}
		if(Input.GetKeyDown (KeyCode.H) == true)
		{
			gameObject.GetComponent<SpriteRenderer>().enabled = true;
		}
	}
}
