using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInfo : MonoBehaviour {
	// check here for weather stats
	// https://www.metaweather.com/api/

	public GameObject total_calls;
	public GameObject LightCloud;
	public GameObject HeavyCloud;

	public string url = "https://battleforthenet.s3.amazonaws.com/leaderboards/internetcountdown.click.json";

	// reference to spawner to access script
	public GameObject Spawner;
	public TextMesh NewText;

	IEnumerator Start() {

		// fetch the actual info, like you would from a browser
		WWW www = new WWW(url);

		// yield return waits for the download to complete before proceeding
		// but since this is in IEnumerator it wont stall the program outright
		yield return www;

		// use a JSON Object to store the info temporarily
		// this makes it easy to access the data struture
		JSONObject tempData = new JSONObject (www.text);

		// this particular API stores all the data under the header
		// "consolidated_weather" so first get in there
		JSONObject total_calls = tempData["total_calls"];
		//JSONObject _24h = tempData["last_24h"];
		//JSONObject  lastweek = tempData["last_week"];

		// log it just to see whats up
		Debug.Log (total_calls.ToString());

		// convert string to a real number
		int NumberTotalCalls = int.Parse (total_calls.ToString ());

		// spawner is the game object that has the script
		//mathf.roundtoint converts the number making sure it is an INT as opposed to a float
		Spawner.GetComponent<NewSpawner> ().TotalThingsToSpawn = Mathf.RoundToInt(NumberTotalCalls / 1000);
		NewText.text = Mathf.RoundToInt(NumberTotalCalls).ToString();

		//Debug.Log (_24h.ToString());
		//Debug.Log (lastweek.ToString());

//		// now we can do cool stuff like...
//		string WeatherType = weatherDetails[0]["weather_state_name"].str;
//		Debug.Log (WeatherType);
//
//		// depending on which type of weather,
//		// activate that game
//		if (WeatherType == "Heavy Cloud") {
//			HeavyCloud.SetActive (true);
//		}
//
//		if (WeatherType == "Light Cloud") {
//			LightCloud.SetActive (true);
//		}
	}
}
