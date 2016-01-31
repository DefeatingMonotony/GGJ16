using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {
	private float time;
	private bool nexted;

	// Use this for initialization
	void Start () {
		time = 0.0f;
		nexted = false;
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime * 1.5f;
		float scale = Mathf.Clamp(time, 0.0f, 1.0f);
		transform.localScale = new Vector3(scale, scale, 1.0f);
		if (!nexted && time >= 1.5f) {
			Timer.Next();
			nexted = true;
		}
	}
}
