using UnityEngine;
using System.Collections;

public class CountTriggerEnter : MonoBehaviour {

	public int goalNum;
	public int triggerCount;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(triggerCount >= goalNum){
			Timer.Win();
		}
	}
	
	void OnTriggerEnter2D(Collider2D col){
		triggerCount++;
	}
	
	void OnTriggerExit2D(Collider2D col){
		triggerCount--;
	}
}
