using UnityEngine;
using System.Collections;

public class FlowerScript : MonoBehaviour {
	private bool overlapping = false;
	private float time = float.NaN;
	public float wait = 2.0f;

	// Use this for initialization
	void Start () {
		overlapping = false;
		GameObject.FindObjectOfType<Timer>().run = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!float.IsNaN(time)) {
			time += Time.deltaTime;
			if (time >= wait) {
				GameObject.Find("FadeToBlack").GetComponent<SceneFadeInOut>().EndScene();
				time = float.NaN;
			}
		}
		if (overlapping && Input.GetMouseButtonUp(0)) {
			Destroy(GameObject.Find("FlowerObj").GetComponent<MouseDrag>());
			time = 0.0f;
			overlapping = false;
		}
	}

	void OnTriggerEnter2D(Collider2D col) {
		overlapping = true;
	}

	void OnTriggerExit2D(Collider2D col) {
		overlapping = false;
	}
}
