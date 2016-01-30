using UnityEngine;
using System.Collections;

public class Dragable : MonoBehaviour {

	public SpringJoint2D spring;
	public float dampening = 5.0f;
	private float dampStore;

	void Awake()
	{
		spring = this.gameObject.GetComponent<SpringJoint2D>();
		spring.enabled = false;
	}


	void OnMouseDown()
	{
		dampStore = GetComponent<Rigidbody2D>().drag;
		GetComponent<Rigidbody2D>().drag = dampening;
		spring.enabled = true;
		spring.connectedAnchor = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		spring.anchor = transform.InverseTransformPoint (spring.connectedAnchor);
	}


	void OnMouseDrag()        
	{
		if (spring.enabled == true) 
		{
			Vector2 cursorPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			spring.connectedAnchor = cursorPosition;
		}
	}


	void OnMouseUp()        
	{
		spring.enabled = false;
		GetComponent<Rigidbody2D>().drag = dampStore;
	}
}
