using UnityEngine;
using System.Collections;

public class MouseDrag : MonoBehaviour {
	public float score = 100.0f;
	public bool scoring, held;
	// Use this for initialization
	void Start () {
		scoring = false;
		held = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(scoring && held){
			//Debug.Log("Testing");
			score -= (Mathf.Abs(Input.GetAxis("Mouse X")) + Mathf.Abs(Input.GetAxis("Mouse Y")));
			if(score<=0){
				Timer.Win();
			}
		}
	}

	void OnMouseDown() {
		held = true;
	}

	void OnMouseUp() {
		held = false;
	}
	
	void OnMouseDrag(){
		Vector3 newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,0));
		newPos.z = 0;
		transform.position = newPos;
	}

	public void StartScoring() {
		scoring = true;
	}
}
