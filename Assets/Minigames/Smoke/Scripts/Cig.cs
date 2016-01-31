using UnityEngine;
using System.Collections;

public class Cig : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		
		Vector3 mouselocation = Camera.main.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector3(mouselocation.x,mouselocation.y,-1);
	}
}