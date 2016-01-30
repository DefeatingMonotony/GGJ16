using UnityEngine;
using System.Collections;

public class BlockOut : MonoBehaviour {
	public Transform circle;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown () {
		Vector3 mouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Transform blob = Instantiate(circle, new Vector3(mouse.x, mouse.y, 1.0f), Quaternion.identity) as Transform;
		GameObject cover = GameObject.Find("CoverTrigger");
		if (blob.GetComponent<BoxCollider2D>().bounds.Intersects(cover.GetComponent<BoxCollider2D>().bounds)) {
			cover.GetComponent<Cover>().HandleDraw(blob);
		}
	}

	void OnMouseDrag () {
		Vector3 mouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Transform blob = Instantiate(circle, new Vector3(mouse.x, mouse.y, 1.0f), Quaternion.identity) as Transform;
		GameObject cover = GameObject.Find("CoverTrigger");
		if (blob.GetComponent<BoxCollider2D>().bounds.Intersects(cover.GetComponent<BoxCollider2D>().bounds)) {
			cover.GetComponent<Cover>().HandleDraw(blob);
		}
	}
}
