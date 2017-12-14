using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionCube : MonoBehaviour {

	void OnMouseOver() {
		// add .01 to all axes scale
		transform.localScale += new Vector3 (.01f, .01f, .01f);
	}
}