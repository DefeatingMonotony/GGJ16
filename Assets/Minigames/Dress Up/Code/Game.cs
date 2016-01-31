using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

    public GameObject Character;
    public Camera MainCam;
    public GameObject Pants, Shirt, Hat, Sock, Towel;
	public bool isPants, isShirt, FINISH;
	public Sprite Nguy,Pguy,Sguy,Cguy;
	// Use this for initialization
	void Start () {
		isPants = false;
		isShirt = false;
		Character.GetComponent<SpriteRenderer> ().sprite = Nguy;
		Shuffle ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Pants) {
			if (Pants.GetComponent<ClickableObject> ().Clicked) {
				isPants = true;
				Destroy (Pants);
			}
		}
		if (Shirt) {
			if (Shirt.GetComponent<ClickableObject> ().Clicked) {
				isShirt = true;
				Destroy (Shirt);
			}
		}
		if (Hat.GetComponent<ClickableObject>().Clicked || Towel.GetComponent<ClickableObject>().Clicked || Sock.GetComponent<ClickableObject> ().Clicked)
		{
			Shuffle();
		}
		if (isPants && !isShirt) {
			Character.GetComponent<SpriteRenderer> ().sprite = Pguy;
		}
		if (isShirt && !isPants) {
			Character.GetComponent<SpriteRenderer> ().sprite = Sguy;
		}
		if (isShirt && isPants) {
			Character.GetComponent<SpriteRenderer> ().sprite = Cguy;
			FINISH = true;
		}
	}

	void Shuffle()
	{
		if (Pants) {
			Pants.transform.position = new Vector3 (Random.Range (-6, 1), Random.Range (-4, 4), 0);
		}
		if (Shirt) {
			Shirt.transform.position = new Vector3 (Random.Range (-6, 1), Random.Range (-4, 4), 0);
		}
		Sock.transform.position = new Vector3(Random.Range(-6, 1) ,Random.Range(-4, 4), 0 );
		Towel.transform.position = new Vector3(Random.Range(-6, 1) ,Random.Range(-4, 4), 0 );
		Hat.transform.position = new Vector3(Random.Range(-6, 1) ,Random.Range(-4, 4), 0 );



	}
   
}
