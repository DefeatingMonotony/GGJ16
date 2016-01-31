using UnityEngine;
using System.Collections;

public class MeshTest : MonoBehaviour {
	
	public Transform startObject;
	public Transform[] vertObjects;
	public Vector3[] newVertices;
	public Vector2[] newUV;
	public int[] newTriangles;

	// Use this for initialization
	void Start () {
		
		
	
	
		Mesh mesh = new Mesh();
		GetComponent<MeshFilter>().mesh = mesh;
		for(int i=0;i<vertObjects.Length;i++){
			newVertices[i] = vertObjects[i].position;
			newUV[i] = new Vector2(vertObjects[i].position.x,vertObjects[i].position.y);
		}
		mesh.vertices = newVertices;
		mesh.uv = newUV;
		mesh.triangles = newTriangles;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnDrawGizmos(){
		Gizmos.color = new Color(1,0,0,.5f);
		Mesh mesh = new Mesh();
		GetComponent<MeshFilter>().mesh = mesh;
		for(int i=0;i<vertObjects.Length;i++){
			newVertices[i] = vertObjects[i].position;
			newUV[i] = new Vector2(vertObjects[i].position.x,vertObjects[i].position.y);
		} 
		mesh.vertices = newVertices;
		mesh.uv = newUV;
		mesh.triangles = newTriangles;
		Gizmos.DrawMesh(mesh,transform.position);
	}
}
