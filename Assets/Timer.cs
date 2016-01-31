using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;

public class Timer : MonoBehaviour {
	public int level = 0;
	public float seconds = 60.0f;
	private float timeRemaining;
	private bool won = false;
	public bool run = false;
	public bool active = true;
	public Transform winPrefab;
	public Color beginColor;
	public Color endColor;

	// Use this for initialization
	void Awake () {
		if (GameObject.FindObjectOfType<Timer>() != this) Destroy(gameObject);
		else {
			DontDestroyOnLoad(transform.gameObject);
			timeRemaining = seconds;

			transform.position = new Vector3(Camera.main.orthographicSize * Camera.main.aspect - 0.2f, Camera.main.orthographicSize, 0.0f);
		}
	}

	public void StartTimer () {
		timeRemaining = seconds;
		run = true;
		active = true;

		SceneManager.LoadScene(level = 2);
	}
	
	// Update is called once per frame
	void Update () {
		string time;
		if (run) {
			timeRemaining -= Time.deltaTime;
			if (active && timeRemaining <= 0.0f) {
				SceneManager.LoadScene(1);
				run = false;
				timeRemaining = seconds;
			}
			Camera.main.backgroundColor = Color.Lerp(beginColor,endColor,(float)(SceneManager.GetActiveScene().buildIndex) / (float)(SceneManager.sceneCountInBuildSettings));

			time = string.Format("{2}{0}:{1:D2}", Math.Abs((int) ((timeRemaining + 1.0f) / 60.0f)), Math.Abs(Mathf.CeilToInt(timeRemaining) % 60), 
				(timeRemaining <= 1.0f) ? "-" : "");
		} else {
			time = "";
		}

		TextMesh mesh = transform.GetComponent<TextMesh>();
		mesh.text = time;
		transform.position = new Vector3(Camera.main.orthographicSize * Camera.main.aspect - 0.2f, Camera.main.orthographicSize, 0.0f);
	}

	public static void Next() {
		Timer timer = GameObject.FindObjectOfType<Timer>();
		if(timer.level + 1 < SceneManager.sceneCountInBuildSettings){
			timer.won = false;
			SceneManager.LoadScene(++timer.level);
		}else{
			Debug.Log("no more levels");
			timer.run = false;
		}
	}

	public static void Win() {
		Timer timer = GameObject.FindObjectOfType<Timer>();
		if (!timer.won) {
			timer.won = true;
			Instantiate(timer.winPrefab);
		}
	}
}
