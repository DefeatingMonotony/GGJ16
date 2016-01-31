using UnityEngine;
using System.Collections;

public class MouseDragDelayed : MonoBehaviour {
	public float speed;
	private Vector2 newPos;

	void Start() {
		newPos = transform.position;
		Title.ChangeTitle("Leaky Pipe");
	}

	void FixedUpdate() { 
		GetComponent<Rigidbody2D>().MovePosition(Vector2.Lerp(transform.position,newPos,speed * Time.deltaTime));
	}
	
	void OnMouseDrag(){
		newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}

	void OnMouseUp() {
		newPos = transform.position;
	}
}
