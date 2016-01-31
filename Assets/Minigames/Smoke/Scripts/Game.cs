using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour {


	public List<GameObject> Faces;
	public Pack pack;
	public bool HasCig,win;
	public GameObject Cig,ActiveFace,curCig;
	public int AF;
	// Use this for initialization
	void Start () {
		AF = Random.Range (0, Faces.Count);
		Faces [AF].gameObject.GetComponent<Face> ().Change = true;
		ActiveFace = Faces [AF];
	}
	
	// Update is called once per frame
	void Update () {
		if (!HasCig) {
			if (pack.Clicked) {
				pack.Clicked = false;
				HasCig = true;
				curCig = Instantiate (Cig);
			}
		}
		if (ActiveFace.GetComponent<Face> ().Finishing == true) 
		{
			curCig.GetComponent<Cig> ().boom = true;
			HasCig = false;
			Faces.RemoveAt (AF);
			if (Faces.Count > 0) {
				AF = Random.Range (0, Faces.Count);
				Faces [AF].gameObject.GetComponent<Face> ().Change = true;
				ActiveFace = Faces [AF];
			} else if (Faces.Count == 0) {
				win = true;
			}
		}
		//
	}
}
