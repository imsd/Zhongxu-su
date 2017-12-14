using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMovement : MonoBehaviour {
	
	
	public float Power = 500f;

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
		if (Input.GetKeyDown ("w")) {
			Vector3 Moveforward = Vector3.forward * Power;
			GetComponent<Rigidbody> ().AddForce (Moveforward);
		}
		if (Input.GetKeyDown ("s")) {
			Vector3 Moveback = Vector3.back * Power;
			GetComponent<Rigidbody> ().AddForce (Moveback);
				}
		if (Input.GetKeyDown ("a")) {
			Vector3 Moveletf = Vector3.left * Power;
			GetComponent<Rigidbody> ().AddForce (Moveletf);
		}
		if (Input.GetKeyDown ("d")) {
			Vector3 Moveright = Vector3.right * Power;
			GetComponent<Rigidbody> ().AddForce (Moveright);
		}

		}
	}
