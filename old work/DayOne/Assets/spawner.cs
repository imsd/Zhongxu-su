using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
	public GameObject go;
	//start spawning after x sec
	public float StartAfter = 1f;
	//how offen to spawn the item
	public float SpawnFrequency = .5f;
	// Use this for initialization
		void Start () {
		// repeat a function
		//1 what you want to repeat
		//2 how many sec
		//3 repeat x sec
		InvokeRepeating ("SpawnThing", StartAfter, SpawnFrequency);

		
	}
	
	// Update is called once per frame
	void SpawnThing () {
		// moving the spawner
		transform.position = new Vector3(Random.Range(-5,5),10,Random.Range(-5,5));

		Instantiate (go, transform.position, Quaternion.identity);
		Debug.Log(transform.position);

	}
}
