using UnityEngine;
using System.Collections;

public class ADMove : MonoBehaviour {

	public float movSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetAxis("Horizontal") > 0){
			GetComponent<Rigidbody2D>().MovePosition(Vector2.Lerp(transform.position, transform.position + transform.right, Time.deltaTime * movSpeed));
		}
		
		if(Input.GetAxis("Horizontal") < 0){
			GetComponent<Rigidbody2D>().MovePosition(Vector2.Lerp(transform.position, transform.position - transform.right, Time.deltaTime * movSpeed));
		}
		//transform.position += transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * movSpeed;
	}
}
