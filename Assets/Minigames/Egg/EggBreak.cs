using UnityEngine;
using System.Collections;

public class EggBreak : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(){
		GameObject bot = GameObject.Find("Bottom");
		GameObject top = GameObject.Find("Top");
		GameObject yolk = GameObject.Find("Yolk");
		
		bot.layer = 0;
		top.layer = 0;
		
		bot.AddComponent<Rigidbody2D>();
		bot.GetComponent<Rigidbody2D>().interpolation = RigidbodyInterpolation2D.Interpolate;
		bot.GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Continuous;
		top.AddComponent<Rigidbody2D>();
		top.GetComponent<Rigidbody2D>().interpolation = RigidbodyInterpolation2D.Interpolate;
		top.GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Continuous;
		yolk.AddComponent<Rigidbody2D>();
		yolk.GetComponent<Rigidbody2D>().interpolation = RigidbodyInterpolation2D.Interpolate;
		yolk.GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode2D.Continuous;
		
		Timer.Win();
	}
}
