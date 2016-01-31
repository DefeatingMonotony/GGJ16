using UnityEngine;
using System.Collections;

public class BallCheck : MonoBehaviour {
	
	public int balls = 5;
	
	void Update(){
		if(balls<=0){
			Timer.Win();
		}
	}

	void OnTriggerExit2D(Collider2D col){
		balls--;
	}
}
