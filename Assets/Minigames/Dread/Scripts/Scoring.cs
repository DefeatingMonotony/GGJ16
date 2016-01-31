using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour {

	public float time = 2.0f;
	public bool isTriggered = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(!isTriggered){
			time -= Time.deltaTime;
		}
		if(time<=0.0f){
			Timer.Win();
		}
	}
	
	void OnTriggerEnter2D(Collider2D col){
		isTriggered = true;
	}
	
	void OnTriggerExit2D(Collider2D col){
		isTriggered = false;
	}
}
