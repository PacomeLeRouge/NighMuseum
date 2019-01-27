using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class buttonInfo : MonoBehaviour {

	public Transform target;
	public GameObject UIpanel;
	public GameObject waypointUI;
    public GameObject title;
	int counter;


	void Update ()
	{
		{
			Vector3 relativePos = target.position - transform.position;
			transform.rotation = Quaternion.LookRotation (relativePos);
		}

	}
	public void showhidePanel () {
		counter++;
		if (counter % 2 == 1){
			UIpanel.gameObject.SetActive(true);
			waypointUI.gameObject.SetActive (false);
            title.gameObject.SetActive(false);
        }
		else {
			UIpanel.gameObject.SetActive (false);
			waypointUI.gameObject.SetActive (true);}
		Debug.Log ("Button.showhidePanel() was called");
	}

}