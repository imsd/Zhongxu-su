using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardLeftRight : MonoBehaviour {

	public float multiplier = 7f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// take in input from keyboard and multiply (scale up)
		float rotationX = Input.GetAxis("Vertical") * multiplier;

		// same for up/down
		float rotationY = Input.GetAxis("Horizontal") * multiplier;

		// put that number into a vec3 so we can work with it
		Vector3 v3 = new Vector3 (rotationX, rotationY, 0);

		// rotate!
		transform.Rotate (v3);

	}
}