using UnityEngine;
using System.Collections;

public class EggDrag : MonoBehaviour {

	public SpringJoint2D spring;
	public float dampening = 5.0f;
	
	void Start(){
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10));
		spring = this.gameObject.GetComponent<SpringJoint2D>();
		spring.enabled = false;
		GetComponent<Rigidbody2D>().drag = dampening;
		spring.enabled = true;
		spring.connectedAnchor = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		spring.anchor = transform.InverseTransformPoint (spring.connectedAnchor);

		}
	
	void FixedUpdate(){
		if (spring.enabled == true) 
		{
			Vector2 cursorPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			spring.connectedAnchor = cursorPosition;
		}
	}
}
