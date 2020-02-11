using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerateTowards : MonoBehaviour {

	[SerializeField]
	Transform transTowards;

	[SerializeField]
	float fSpeed;

	Rigidbody rigid;

	// Use this for initialization
	void Start () 
	{
		rigid = GetComponent<Rigidbody> ();
		if (transTowards == null) 
		{
			transTowards = FindObjectOfType<AddPlayerControlledVelocity> ().transform;
		}

	}
	
	// Update is called once per frame
	void Update () 
	{
		rigid.velocity += (transTowards.position - transform.position).normalized * fSpeed * Time.deltaTime; //if we used FixedUpdate(), we wouldnt need to multiply Time.deltatime

	}
}
