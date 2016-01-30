using UnityEngine;
using System.Collections;

public class CircleMove : MonoBehaviour {
	private int state = 0;
	public float speed = 0.3f;

	// Use this for initialization
	void Start() {

	}

	void FixedUpdate() {
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float mag = speed;
		int last = 0;
		while (mag > 0.0f) {
			if (state == 13) break;
			bool isX = (state % 2) != 0;
			if (isX) {
				float maxX = 3.0f - (state / 4);
				float minX = -maxX + (((state % 4) == 3) ? 1.0f : 0.0f);
				float moveX = mousePos.x - transform.position.x;
				if (Mathf.Abs(moveX) <= mag) {
					mag = 0.0f;
				} else {
					moveX = mag * Mathf.Sign(moveX);
				}
				float posX = transform.position.x + moveX;
				if (posX >= maxX) {
					mag -= maxX - transform.position.x;
					transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
					if ((state % 4) == 1) {
						if (last == -1) break;
						++state;
						last = 1;
					} else {
						if (last == 1) break;
						--state;
						last = -1;
					}
				} else if (posX <= minX) {
					mag -= transform.position.x - minX;
					transform.position = new Vector3(minX, transform.position.y, transform.position.z);
					if ((state % 4) == 3) {
						if (last == -1) break;
						++state;
						last = 1;
					} else {
						if (last == 1) break;
						--state;
						last = -1;
					}
				} else {
					transform.position = new Vector3(posX, transform.position.y, transform.position.z);
					mag = 0.0f;
				}
			} else {
				float maxY = 3.0f - (state / 4);
				float minY = -maxY - (((state % 4) == 0 && state != 0) ? 1.0f : 0.0f);
				float moveY = mousePos.y - transform.position.y;
				if (Mathf.Abs(moveY) <= mag) {
					mag = 0.0f;
				} else {
					moveY = mag * Mathf.Sign(moveY);
				}
				float posY = transform.position.y + moveY;
				if (posY >= maxY) {
					mag -= maxY - transform.position.y;
					transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
					if ((state % 4) == 0) {
						if (last == -1) break;
						++state;
						last = 1;
					} else {
						if (last == 1) break;
						--state;
						last = -1;
					}
				} else if (posY <= minY) {
					mag -= transform.position.y - minY;
					transform.position = new Vector3(transform.position.x, minY, transform.position.z);
					if ((state % 4) == 2) {
						if (last == -1) break;
						++state;
						last = 1;
					} else {
						if (state == 0) break;
						if (last == 1) break;
						--state;
						last = -1;
					}
				} else {
					transform.position = new Vector3(transform.position.x, posY, transform.position.z);
					mag = 0.0f;
				}
			}
		}
		if (state == 13) Debug.Log("Winner");
	}
}
