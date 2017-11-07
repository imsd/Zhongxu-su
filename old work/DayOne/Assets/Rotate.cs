using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public Vector3 myRotation;

	// Use this for initialization
	// public before a variable type
	// vector3 is a variable type that store
	// x,y,z information

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate ( myRotation * Time.deltaTime);


	}
}
