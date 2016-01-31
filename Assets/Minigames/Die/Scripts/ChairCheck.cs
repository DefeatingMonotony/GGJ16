using UnityEngine;
using System.Collections;

public class ChairCheck : MonoBehaviour {
	bool off = false;
	
	void Update(){
		if(off){
			Destroy(GameObject.Find("Chair Back").GetComponent<MouseDragParentBody>());
			Debug.Log("Winner");
			//Timer.Win();
			off = false;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		off = true;
	}
}
