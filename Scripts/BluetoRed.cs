using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluetoRed : MonoBehaviour {

	public GameObject Ball;
	public Material red;
	public Material blue;

	private void OnCollisionEnter(Collision other)
	{
		Ball.GetComponent<Renderer> ().material = blue;	
		gameObject.tag = "Enemy";
	}

	// Use this for initialization
	void Start () 
	{
		Ball.GetComponent<Renderer> ().material = red;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
