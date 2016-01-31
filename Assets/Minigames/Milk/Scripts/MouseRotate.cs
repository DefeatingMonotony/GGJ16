using UnityEngine;
using System.Collections;

public class MouseRotate : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Title.ChangeTitle("Hydrate");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDrag(){		
		//http://answers.unity3d.com/questions/585035/lookat-2d-equivalent-.html
		Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.parent.position;
		diff.Normalize();
		
		float rot_z = Mathf.Atan2(diff.y,diff.x) * Mathf.Rad2Deg;
		transform.parent.rotation = Quaternion.Euler(0f,0f,rot_z);
	}
}
