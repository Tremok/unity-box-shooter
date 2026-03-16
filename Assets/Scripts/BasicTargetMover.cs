using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour {
	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f;

	public bool do_spin = true;
	public bool do_motion = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (do_spin) {
			//rotate around the up axis of the gameObject
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
		}

		if (do_motion) {
			//move up and down over time 
			gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
		}
	}
}
