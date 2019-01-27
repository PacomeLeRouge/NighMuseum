using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {

	public GameObject SFX;
	public GameObject startButton;
	public GameObject waypoint;


	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 100 * Time.deltaTime, 0, Space.Self);
	}

	public void OnStartClicked () {
		if (Input.GetMouseButtonDown (0)){
			SFX.GetComponent<GvrAudioSource> ().Play ();
			waypoint.gameObject.SetActive (true);
			Camera.main.transform.parent.transform.position = gameObject.transform.position;
			Destroy (gameObject);
		}

		Debug.Log ("Button.OnStartClicked() was called");

	}
}
