using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevel : MonoBehaviour {

	public float speed;
	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.Rotate (Vector3.left * speed);
	}
}
