using UnityEngine;
using System.Collections;

public class IsObjectInTrigger : MonoBehaviour {
	public GameObject target;
	public bool result;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D col){
		
		if(col.gameObject == target){
			result = true;
			Debug.Log("Win");
			Timer.Win();
		}
	}
}
