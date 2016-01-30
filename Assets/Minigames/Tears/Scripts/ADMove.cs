using UnityEngine;
using System.Collections;

public class ADMove : MonoBehaviour {

	public float movSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * movSpeed;
	}
}
