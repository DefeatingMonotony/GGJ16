using UnityEngine;
using System.Collections;

public class MouseDragParentX : MonoBehaviour {
	private float goalX;
	private float offset;
	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		goalX = transform.parent.position.x;
		offset = goalX;
	}

	// Update is called once per frame
	void FixedUpdate () {
		float delta = goalX - offset;
		delta = Mathf.Clamp(delta, -speed, speed);
		Vector3 pos = transform.parent.position;
		pos.x += delta;
		transform.parent.position = pos;
		offset += delta;
	}

	void OnMouseDown(){
		offset = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
		goalX = offset;
	}

	void OnMouseUp(){
		goalX = transform.parent.position.x;
		offset = goalX;
	}

	void OnMouseDrag(){
		goalX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
	}
}
