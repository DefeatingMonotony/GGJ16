using UnityEngine;
using System.Collections;

public class Pack : MonoBehaviour {

	public bool Clicked;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		Clicked = true;
	}
}
