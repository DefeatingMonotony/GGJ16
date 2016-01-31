using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneFadeInOut : MonoBehaviour
{
	public float fadeSpeed = 0.3f;
	public bool sceneStart = true;
	public int level = 0;
	private bool sceneStarting;
	private bool sceneEnding;
	private float fade;

	void Awake ()
	{
		sceneStarting = sceneStart;
		sceneEnding = false;
		if (!sceneStart) GetComponent<GUITexture>().color = Color.clear;

		if (sceneStart) fade = 0.0f;
		else fade = 1.0f;

		GetComponent<GUITexture>().pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
		GetComponent<GUITexture>().enabled = true;
	}

	void Update ()
	{
		if(sceneStarting)
			DoStartScene();
		else if (sceneEnding)
			DoEndScene();
	}

	void DoStartScene ()
	{
		fade += fadeSpeed * Time.deltaTime;
		Color c = GetComponent<GUITexture>().color;
		c.a = 1.0f - Mathf.Sqrt(Mathf.Clamp(fade, 0.0f, 1.0f));
		GetComponent<GUITexture>().color = c;
		if(fade >= 1.0f)
		{
			GetComponent<GUITexture>().color = Color.clear;
			GetComponent<GUITexture>().enabled = false;
			sceneStarting = false;
		}
	}

	void DoEndScene ()
	{
		fade -= fadeSpeed * Time.deltaTime;
		GetComponent<GUITexture>().enabled = true;
		Color c = GetComponent<GUITexture>().color;
		c.a = 1.0f - Mathf.Sqrt(Mathf.Clamp(fade, 0.0f, 1.0f));
		GetComponent<GUITexture>().color = c;
		if(fade <= 0.0f)
			SceneManager.LoadScene(level);
	}

	public void EndScene() {
		sceneEnding = true;
	}
}
