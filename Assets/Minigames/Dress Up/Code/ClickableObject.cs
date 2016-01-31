using UnityEngine;
using System.Collections;

public class ClickableObject : MonoBehaviour {

	public bool Clicked;
	// Use this for initialization
	void Start () {
		Clicked = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Clicked) {
			Clicked = false;
		}
	}

	void OnMouseDown()
	{
		Clicked = true;
	}
}
