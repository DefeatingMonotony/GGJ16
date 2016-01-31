using UnityEngine;
using System.Collections;

public class ChairCheck : MonoBehaviour {
	public float wait = 3.0f;
	private bool off = false;
	private float timer = float.NaN;
	
	void Update(){
		if (!float.IsNaN(timer)) {
			timer += Time.deltaTime;
			if (timer >= wait) {
				GameObject.Find("FadeToBlack").GetComponent<SceneFadeInOut>().EndScene();
			}
		}
		if(off){
			Destroy(GameObject.Find("Chair Back").GetComponent<MouseDragParentBody>());
			timer = 0.0f;
			off = false;
		}
	}

	void OnTriggerExit2D(Collider2D col){
		off = true;
		GameObject.FindObjectOfType<Timer>().active = false;
	}
}
