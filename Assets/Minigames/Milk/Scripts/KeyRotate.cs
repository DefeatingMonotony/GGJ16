using UnityEngine;
using System.Collections;

public class KeyRotate : MonoBehaviour {
	// Use this for initialization
	
	public float speed;
	void Start () {
		Title.ChangeTitle("Flavor your coffee");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Horizontal")>0){
			transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.Euler(0,0,0), speed * Time.deltaTime);
		}
	}
}
