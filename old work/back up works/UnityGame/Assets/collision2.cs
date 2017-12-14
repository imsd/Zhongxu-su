using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision2 : MonoBehaviour {

	// basic collision detection
	void OnCollisionEnter(Collision coll) {
		// what object am I colliding with?
		//Debug.Log (coll.gameObject.name);

		// destroy the other game object 

		Destroy (coll.gameObject);

		// destroy THIS game object
		//Destroy(this.gameObject);

		// rotate the collided object
		//coll.gameObject<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

		// turn the collided object a different color (red)
		//coll.gameObject.GetComponent<Renderer>().material.color = Color.red;
	}
}