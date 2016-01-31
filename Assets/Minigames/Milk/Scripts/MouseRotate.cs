using UnityEngine;
using System.Collections;

public class MouseRotate : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Title.ChangeTitle("Don't cry");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDrag(){		
		//http://answers.unity3d.com/questions/585035/lookat-2d-equivalent-.html
		Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.parent.position;
		diff.Normalize();
		
		float rot_z = Mathf.Atan2(diff.y,diff.x) * Mathf.Rad2Deg;
		Debug.Log(rot_z);
		rot_z=Mathf.Clamp(rot_z,0,90);
		transform.parent.rotation = Quaternion.Euler(0f,0f,rot_z);
	}
}
