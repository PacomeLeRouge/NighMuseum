using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointButton : MonoBehaviour {
	public Transform target;

	void Update ()
	{
		{
		Vector3 relativePos = target.position - transform.position;
			transform.rotation = Quaternion.LookRotation (relativePos);
		}
	}

	public void OnClicked()
	{
		if (Input.GetMouseButtonDown (0)){
		Camera.main.transform.parent.transform.position = gameObject.transform.position;
		}
	}
}