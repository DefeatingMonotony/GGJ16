using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Count : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Timer timer = GameObject.FindObjectOfType<Timer>();
		Text text = GetComponent<Text>();
		text.text = string.Format(text.text, timer.level - 2);
	}
}
