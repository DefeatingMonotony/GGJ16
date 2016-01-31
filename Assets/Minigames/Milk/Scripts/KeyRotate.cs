using UnityEngine;
using System.Collections;

public class KeyRotate : MonoBehaviour {
	// Use this for initialization
	
	public float speed;
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetAxis("Horizontal")>0){
			transform.GetComponent<Rigidbody2D>().rotation = Mathf.Max(
				transform.GetComponent<Rigidbody2D>().rotation - speed * Time.deltaTime, 0.0f);
		}
	}
}
