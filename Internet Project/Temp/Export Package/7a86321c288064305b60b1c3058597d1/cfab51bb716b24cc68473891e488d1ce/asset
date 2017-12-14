using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawner : MonoBehaviour {

	// add a gameobject to the inspector
	// that we can access in this script
	public GameObject go;

	// start spawning after... seconds
	public float StartAfter = 1f;

	// how often to spawn objects?
	public float SpawnFrequency = .3f;

	public int TotalThingsToSpawn;
	private int ThingsSpawnedSoFar = 0;

	// Use this for initialization
	void Start () {
		// repeat a function
		// 1: what you want to repeat (as a function)
		// 2: after how many seconds do you want to start doing it?
		// 3: repeat every X seconds
		InvokeRepeating("SpawnThing", StartAfter, SpawnFrequency);
	}

	void Update() {
		if (ThingsSpawnedSoFar < TotalThingsToSpawn) {
			//spawn a new one
			/// instantiate ....


			// increase total so far count
			ThingsSpawnedSoFar++;
		}
	}

	// Update is called once per frame
	void SpawnThing () {

		// first, move the spawner
		transform.position = new Vector3(Random.Range(-17f,28f), 10, Random.Range(-8f,8f));

		// to create an object, first use Instantiate function
		// which wants 3 arguments:
		// 1: the object you will create
		// 2: WHERE to create that object
		// 3: at what rotation
		Instantiate (go, transform.position, Quaternion.identity);

		// print the location of the spawner object
		Debug.Log(transform.position);
	}
}
