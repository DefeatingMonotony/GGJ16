using UnityEngine;
using System.Collections;
using System.Text;

public class ShiftText : MonoBehaviour {
	public int framesPerCycle = 6;
	private int cycle;

	// Use this for initialization
	void Start () {
		cycle = framesPerCycle;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (++cycle >= framesPerCycle) {
			cycle = 0;

			StringBuilder text = new StringBuilder("");
			for (int i=0; i < 512; ++i) {
				if (i % 32 == 31) text.Append('\n');
				else if (i == 296) {
					text.Append("DESPAIR");
					i += 6;
				} else {
					text.Append((char) ('A' + Random.Range(0, 26)));
				}
			}

			TextMesh mesh = transform.GetComponent<TextMesh>();
			mesh.text = text.ToString();
		}
	}
}
