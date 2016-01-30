using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public bool reverse;
	public Vector3 startPos;
	public Vector3 endPos;
	public float speed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(reverse){
			transform.position = Vector3.Lerp(transform.position,startPos,speed * Time.deltaTime);
			if(Vector3.Distance(transform.position,startPos)<= 1){
				reverse=false;
			}
		}else{
			transform.position = Vector3.Lerp(transform.position,endPos,speed * Time.deltaTime);
			if(Vector3.Distance(transform.position,endPos) <= 1){
				reverse=true;
			}
		}
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.blue;
		Gizmos.DrawSphere(startPos,.5f);
		Gizmos.DrawSphere(endPos,.5f);
	}
}
