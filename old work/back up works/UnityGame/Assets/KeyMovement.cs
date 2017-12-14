using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMovement : MonoBehaviour {


	public float Power = 1f;
	public float Powers = 1f;
	public float Thrust = 1f;
	public Vector3 myRotation;

	// function gets called when the mouse is hovering
	// over the object
	//void OnMouseDown() {
	//Vector3 forceDirection = Vector3.up * forcePower;
	//GetComponent<Rigidbody> ().AddForce (forceDirection);
	void Update () {
		if (Input.GetKeyDown ("space")) {
			Vector3 Jump = Vector3.up * Power;
			GetComponent<Rigidbody> ().AddForce (Jump);
		}
		if (Input.GetKey ("w")) {
			Vector3 Moveforward = transform.forward * Powers;
			GetComponent<Rigidbody> ().AddForce (Moveforward);
		}
		if (Input.GetKey ("s")) {
			Vector3 Moveback = Vector3.back * Powers;
			GetComponent<Rigidbody> ().AddForce (Moveback);
		}
		if (Input.GetKeyDown ("a")) {
			Vector3 Moveletf = Vector3.left * Powers;
			GetComponent<Rigidbody> ().AddForce (Moveletf);
		}
		if (Input.GetKeyDown ("d")) {
			Vector3 Moveright = Vector3.right * Powers;
			GetComponent<Rigidbody> ().AddForce (Moveright);
		}
		if (Input.GetKeyDown ("q")) {
			Vector3 thrust = Vector3.forward * Thrust;
			GetComponent<Rigidbody> ().AddForce (thrust);
		}

	}
}
