using UnityEngine;
using System.Collections;

public class MouseRotate90 : MonoBehaviour {
	public float speed = 0.04f;
	private Vector3 mousePos;
	private bool mouseValid = true;

	// Use this for initialization
	void Start () {
		mouseValid = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//http://answers.unity3d.com/questions/585035/lookat-2d-equivalent-.html
		if (mouseValid) {
			Vector3 diff = mousePos - transform.parent.position;
			diff.Normalize();

			float rot_z = Mathf.Atan2(diff.y,diff.x) * Mathf.Rad2Deg;
			transform.parent.rotation = Quaternion.Lerp(transform.parent.rotation,Quaternion.Euler(0f,0f,rot_z-90),speed);
		}
	}

	void OnMouseUp(){
		mouseValid = false;
	}
	
	void OnMouseDrag(){
		mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mouseValid = true;
	}
}
