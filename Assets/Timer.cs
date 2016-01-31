using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public static int level = 1;
	public float seconds = 60.0f;
	private float timeRemaining;
	public bool run = false;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad(transform.gameObject);
		timeRemaining = seconds;

		transform.position = new Vector3(Camera.main.orthographicSize * Camera.main.aspect - 0.2f, Camera.main.orthographicSize, 0.0f);
	}

	public void StartTimer () {
		timeRemaining = seconds;
		run = true;

		Application.LoadLevel(1);
	}
	
	// Update is called once per frame
	void Update () {
		string time;
		if (run) {
			timeRemaining -= Time.deltaTime;
			if (timeRemaining <= 0.0f) {
				Debug.Log("Out Of Time");
				run = false;
				timeRemaining = seconds;
			}

			time = string.Format("{0}:{1:D2}", (int) ((timeRemaining + 1.0f) / 60.0f), Mathf.CeilToInt(timeRemaining % 60.0f) % 60);
		} else {
			time = "";
		}

		TextMesh mesh = transform.GetComponent<TextMesh>();
		mesh.text = time;
	}
	
	public static void Win(){
		if(Application.loadedLevel + 1 < Application.levelCount){
			Application.LoadLevel(Application.loadedLevel + 1);
		}else{
			Debug.Log("no more levels");
		}
	}
}
