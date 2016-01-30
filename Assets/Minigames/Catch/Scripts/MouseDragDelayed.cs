using UnityEngine;
using System.Collections;

public class MouseDragDelayed : MonoBehaviour {
	public float speed;
	
	void OnMouseDrag(){
		Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,0));
		newPos.z = 0;
		transform.position = Vector3.Lerp(transform.position,newPos,speed * Time.deltaTime);
	}
}
