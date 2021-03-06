﻿using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	public bool fadeOut;
	public bool fadeIn;
	public float fadeSpeed = 0.1f;
	
	public void FadeOut(){
		fadeOut = true;
	}
	
	public void FadeIn(){
		GetComponent<AudioSource>().Stop();
		GetComponent<AudioSource>().Play();
		GetComponent<AudioSource>().volume = 0f;
		fadeIn = true;
	}
	
	public void Stop(){
		GetComponent<AudioSource>().Stop();
	}
	
	public void Play(){
		GetComponent<AudioSource>().Stop();
		GetComponent<AudioSource>().Play();
		GetComponent<AudioSource>().volume=1f;
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
