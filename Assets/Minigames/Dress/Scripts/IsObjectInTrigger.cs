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
			Destroy(transform.parent.GetComponent<MouseDrag>());
			Vector3 move = target.GetComponent<BoxCollider2D>().bounds.center - GetComponent<BoxCollider2D>().bounds.center;
			move.z = 0.0f;
			transform.parent.position += move;
			result = true;
			Timer.Win();
		}
	}
}
