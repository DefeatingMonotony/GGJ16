using UnityEngine;
using System.Collections;

public class Cover : MonoBehaviour {
	private float xmin, xmax, ymin, ymax;

	// Use this for initialization
	void Start () {
		xmin = xmax = ymin = ymax = float.NaN;
	}
	
	// Update is called once per frame
	void Update () {
		Bounds b = GetComponent<BoxCollider2D>().bounds;
		if (xmin <= b.min.x && xmax >= b.max.x && ymin <= b.min.y && ymax >= b.max.y) {
			Debug.Log("Winner");
		}
	}

	public void HandleDraw(Transform col){
		Vector3 pos = col.position;
		Vector2 size = col.GetComponent<BoxCollider2D>().bounds.size;

		if (float.IsNaN(xmin)) xmin = pos.x - (size.x / 2.0f);
		else xmin = Mathf.Min(xmin, pos.x - (size.x / 2.0f));
		if (float.IsNaN(xmax)) xmax = pos.x + (size.x / 2.0f);
		else xmax = Mathf.Max(xmax, pos.x + (size.x / 2.0f));
		if (float.IsNaN(ymin)) ymin = pos.y - (size.y / 2.0f);
		else ymin = Mathf.Min(ymin, pos.y - (size.y / 2.0f));
		if (float.IsNaN(ymax)) ymax = pos.y + (size.y / 2.0f);
		else ymax = Mathf.Max(ymax, pos.y + (size.y / 2.0f));
	}
}
