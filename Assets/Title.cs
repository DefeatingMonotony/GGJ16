using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Title : MonoBehaviour {
	public TextMesh frontText;
	public TextMesh backText;
	public static string _str;
	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad(transform.gameObject);
		transform.position = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 1f, 10f));
	}
	
	// Update is called once per frame
	void Update () {
		frontText.text = _str;
		backText.text = _str;
	}
	
	public static void ChangeTitle(string str){
		_str = str;
	}
}
