using UnityEngine;
using System.Collections;

public class Cig : MonoBehaviour {

	public bool boom;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		
		Vector3 mouselocation = Camera.main.GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector3(mouselocation.x,mouselocation.y,-1);

		if (boom)
			Destroy (this.gameObject);
	}
}