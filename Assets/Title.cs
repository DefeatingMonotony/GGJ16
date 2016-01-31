using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Title : MonoBehaviour {
	public string title;
	public Vector3 titlePos;
	public TextMesh frontText;
	public TextMesh backText;

	void Awake () {
		transform.position = Camera.main.ViewportToWorldPoint(titlePos);
		frontText.text = title;
		backText.text = title;
	}
}
