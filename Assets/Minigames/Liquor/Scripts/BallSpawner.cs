using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {
	public GameObject ball;
	public float interval;
	bool runOnce;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if((int)(Time.timeSinceLevelLoad) % interval == 0){
			if(!runOnce){
				runOnce = true;
				spawnBalls(10);
			}
		}else{
			runOnce = false;
		}
	}
	
	void spawnBalls(int num){
			for (int i=0;i<num;i++){
				GameObject.Instantiate(ball,transform.position,Quaternion.identity);
			}
		}
}
