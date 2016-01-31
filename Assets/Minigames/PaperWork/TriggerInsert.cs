using UnityEngine;
using System.Collections;

public class TriggerInsert : MonoBehaviour {
	private int papers = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (papers >= 3) {
			Timer.Win();
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		++papers;
	}

	void OnTriggerExit2D(Collider2D col){
		--papers;
	}
}
