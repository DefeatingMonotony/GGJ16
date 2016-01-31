using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour {

	public int score = 200;
	public bool isTriggered = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(!isTriggered){
			score--;
		}
		if(score<=0){
			Debug.Log("win");
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
