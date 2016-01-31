using UnityEngine;
using System.Collections;

public class ColorCorrect : MonoBehaviour {

	// Use this for initialization
	void Awake()
	{
		this.gameObject.GetComponent<MeshRenderer>().material.color = Timer.currColor;

	}
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
