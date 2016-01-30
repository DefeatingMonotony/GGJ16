﻿using UnityEngine;
using System.Collections;

public class XBehavior : MonoBehaviour {
	public bool active = false;
	public Transform next = null;

	// Use this for initialization
	void Start() {
	
	}

	void ShiftRight() {
		transform.Translate(new Vector3(1.25f, 0.0f, 0.0f));
		if (next != null)
			next.GetComponent<XBehavior>().ShiftRight();
	}
	
	// Update is called once per frame
	void Update() {
		if (active && Input.GetKeyDown(KeyCode.X)) {
			if (next != null) {
				XBehavior nbeh = next.GetComponent<XBehavior> ();
				nbeh.active = true;
				nbeh.ShiftRight ();
			} else {
				Debug.Log("Win");
			}
			Destroy(gameObject);
		}
	}
}