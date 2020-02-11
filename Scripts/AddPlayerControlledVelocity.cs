using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour 
{
	[SerializeField]
	float forceAmount;

	Vector3 v3ForceZ;

	Vector3 v3ForceX;

	[SerializeField]
	KeyCode keyZPositive;
	[SerializeField]
	KeyCode keyZNegative;
	[SerializeField]
	KeyCode keyXPositive;
	[SerializeField]
	KeyCode keyXNegative;

	void Start()
	{
		v3ForceX = new Vector3 (forceAmount, 0);
		v3ForceZ = new Vector3 (0, 0, forceAmount);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{

		// v3ForceZ = camera.transform.rotation * v3ForceZ;
			
		if (Input.GetKey (keyZPositive))
			GetComponent<Rigidbody> ().velocity += v3ForceZ;

		if (Input.GetKey(keyZNegative))
			GetComponent<Rigidbody>().velocity -= v3ForceZ;

		if (Input.GetKey(keyXPositive))
			GetComponent<Rigidbody>().velocity += v3ForceX;
		
		if (Input.GetKey(keyXNegative))
			GetComponent<Rigidbody>().velocity -= v3ForceX;
		
	}
}
