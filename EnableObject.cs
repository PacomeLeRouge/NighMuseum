using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableObject : MonoBehaviour {

	public GameObject UIpanel;

	public void showhidePanel () {
		if (Input.GetMouseButtonDown (0)){
			UIpanel.gameObject.SetActive(true);}
		else {
			UIpanel.gameObject.SetActive (false);
		}
	}
}