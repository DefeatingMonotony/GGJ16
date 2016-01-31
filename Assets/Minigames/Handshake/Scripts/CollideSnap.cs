using UnityEngine;
using System.Collections;

public class CollideSnap : MonoBehaviour {

	public bool snapped = false;
	public float score = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(snapped){
			score -= (Mathf.Abs(Input.GetAxis("Mouse X")) + Mathf.Abs(Input.GetAxis("Mouse Y")));
			if(score<=0){
				Debug.Log("You win");
				Timer.Win();
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "TargetHand"){
			col.gameObject.transform.parent.transform.parent = transform.parent;
			snapped = true;
		}
	}
}
