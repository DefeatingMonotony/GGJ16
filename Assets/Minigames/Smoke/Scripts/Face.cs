using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Face : MonoBehaviour {
	
	//public Sprite Sleep, Active, Done;
	public bool Sleeping, Activeing, Finishing;
	public bool Change;
	public List<GameObject> Parts;
	public Material Black,White;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Sleeping && Change) {
			//this.gameObject.GetComponent<SpriteRenderer> ().sprite = Active;
			foreach (GameObject g in Parts) {
				if (g.GetComponent<MeshRenderer> ()) {
					g.GetComponent<MeshRenderer> ().material = White;
				}
			}
			Sleeping = false;
			Activeing = true;
			Change = false;
		}



		if (Activeing && Change) {
			//this.gameObject.GetComponent<SpriteRenderer> ().sprite = Done;
			foreach (GameObject g in Parts) {
				if (g.GetComponent<MeshRenderer>()) {
					g.GetComponent<MeshRenderer> ().material = Black;	

				}
				if (g.GetComponent<SpriteRenderer> ()) {
					g.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
				}
			}

			Activeing = false;
			Finishing = true;
			Change = false;
		}
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Finish" && Activeing)
			Change = true;
	}
}
