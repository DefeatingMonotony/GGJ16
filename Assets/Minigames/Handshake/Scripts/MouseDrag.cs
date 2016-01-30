using UnityEngine;
using System.Collections;

public class MouseDrag : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDrag(){
		Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,0));
		newPos.z = 0;
		transform.position = newPos;
	}
}
