using UnityEngine;
using System.Collections;

public class TriggerDestroyOverTime : MonoBehaviour {
	
	public int destroyed;
	public int destroyGoal;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name != "Wall"){
			Destroy(col.gameObject);
			destroyed++;
			if(destroyed >= destroyGoal){
				Debug.Log("win");
				Timer.Win();
			}
		}
	}
}
