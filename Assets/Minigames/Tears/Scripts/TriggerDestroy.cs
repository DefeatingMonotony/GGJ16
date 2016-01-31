using UnityEngine;
using System.Collections;

public class TriggerDestroy : MonoBehaviour {
	public int destroyGoal;
	public int destroyed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D col){
		Destroy(col.gameObject);
		destroyed++;
		if(destroyed >= destroyGoal){
			Debug.Log("win");
			Timer.Win();
		}
	}
}
