using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour {
	public float delay;
	public float interval;
	public GameObject obj;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnObject",delay,interval);
	}
	
	// Update is called once per frame
	void SpawnObject(){
		GameObject.Instantiate(obj,transform.position,transform.rotation);
	}
}
