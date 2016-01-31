using UnityEngine;
using System.Collections;

public class QuitButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		#if UNITY_EDITOR || UNITY_WEBPLAYER || UNITY_WEBGL || UNITY_IOS
		Destroy(gameObject);
		#endif
	}
	
	// Update is called once per frame
	public void PressQuit () {
		Application.Quit();
	}
}
