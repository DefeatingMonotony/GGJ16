using UnityEngine;
using System.Collections;

public class VacuumMove : MonoBehaviour {

	public float movSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position += transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * movSpeed;
	}
}
