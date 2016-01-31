using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
	
	public GameObject target;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = Vector3.Lerp(transform.position, target.transform.position,speed);
		transform.position = new Vector3(transform.position.x,transform.position.y,-0.03f);
	}
}
