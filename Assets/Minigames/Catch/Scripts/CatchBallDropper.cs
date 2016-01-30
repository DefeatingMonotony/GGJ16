using UnityEngine;
using System.Collections;

public class CatchBallDropper : MonoBehaviour {
	public float interval;
	public GameObject ball;
	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnBalls",0,interval);
	}
	
	// Update is called once per frame
	void SpawnBalls(){
		GameObject.Instantiate(ball,transform.position,transform.rotation);
	}
}
