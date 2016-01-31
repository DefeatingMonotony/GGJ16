using UnityEngine;
using System.Collections;

public class CollideSnap : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.name == "TargetHand"){
			col.transform.parent.transform.parent = transform.parent;
			transform.parent.GetComponent<MouseDrag>().StartScoring();
		}
	}
}
