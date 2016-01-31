using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	public static bool fadeOut;
	public bool fadeIn;
	public float fadeSpeed = 0.1f;
	
	public static void FadeOut(){
		fadeOut = true;
		Debug.Log("fadeOut hit");
	}
	
	public void FadeIn(){
		GetComponent<AudioSource>().Play();
		GetComponent<AudioSource>().volume = 0f;
		fadeIn = true;
		Debug.Log("fadeIn hit");
	}
	
	public void Stop(){
		GetComponent<AudioSource>().Stop();
		Debug.Log("stop hit");
	}
	
	public void Play(){
		GetComponent<AudioSource>().Play();
		Debug.Log("play hit");
	}
	
	// Update is called once per frame
	void Update () {
		if(fadeOut){
			GetComponent<AudioSource>().volume -= fadeSpeed * Time.deltaTime;
			if(GetComponent<AudioSource>().volume <=0){
				GetComponent<AudioSource>().Stop();
				fadeOut=false;
			}
		}
		
		if(fadeIn){
			GetComponent<AudioSource>().volume += fadeSpeed * Time.deltaTime;
			if(GetComponent<AudioSource>().volume == 1){
				fadeIn=false;
			}
		}
	}
}
