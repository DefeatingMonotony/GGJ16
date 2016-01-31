using UnityEngine;
using System.Collections;

public class MouseDragX : MonoBehaviour {
	private float goalX;
	private float offset;
	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		goalX = transform.position.x;
		offset = goalX;
		Debug.Log("Here");
	}

	// Update is called once per frame
	void FixedUpdate () {
		float delta = goalX - offset;
		delta = Mathf.Clamp(delta, -speed, speed);
		Vector3 pos = GetComponent<Rigidbody2D>().position;
		pos.x += delta;
		GetComponent<Rigidbody2D>().position = pos;
		offset += delta;
	}

	void OnMouseDown(){
		offset = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
		Debug.Log(goalX);
		goalX = offset;
	}

	void OnMouseUp(){
		goalX = transform.position.x;
		offset = goalX;
	}

	void OnMouseDrag(){
		goalX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
	}
}
