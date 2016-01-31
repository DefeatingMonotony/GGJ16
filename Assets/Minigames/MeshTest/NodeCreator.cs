using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NodeCreator : MonoBehaviour {
	
	List<Node> nodeList;
	public Vector3 []verts;
	public Vector2 []uv;
	public int []triangles;
	public Mesh mesh;
	// Use this for initialization
	void Start () {
		mesh = new Mesh();
		GetComponent<MeshFilter>().mesh = mesh;
		mesh.vertices = verts;
		mesh.uv = uv;
		mesh.triangles = triangles;
		
		nodeList = new List<Node>(); 
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			var pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,0));
			Node node = new Node(new Vector2(pos.x,pos.y));
			nodeList.Add(node);
			GameObject temp = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			temp.transform.position = new Vector3(pos.x,pos.y,0);
			DrawMesh();
		}
	}
	
	void DrawMesh(){
		if(nodeList.Count >=3 ){
			mesh.Clear();
			
			verts = new Vector3[nodeList.Count];
			
			for(int i=0;i<nodeList.Count;i++){
				verts[i] = new Vector3(nodeList[i].coords.x,nodeList[i].coords.y,0);
			}
			
			
			mesh.vertices = verts;
			
			uv = new Vector2[nodeList.Count];
			for(int i=0;i<nodeList.Count;i++){
				uv[i]=new Vector2(0,1);
			}
			mesh.uv = uv;
			
			var triCount = nodeList.Count - 2;
			triangles = new int[triCount * 3];
			int triangleIndex = 0;
			for(int t=0; t < triCount; t++){
				if( t % 2 == 0){
					triangles[triangleIndex] = t;
					triangles[triangleIndex+1] = t+1;
					triangles[triangleIndex+2] = t+2;
				}else{
					triangles[triangleIndex] = t;
					triangles[triangleIndex+1] = t+2;
					triangles[triangleIndex+2] = t+1;
				}
				triangleIndex += 3;
				mesh.triangles = triangles;
				//mesh.RecalculateNormals();
			}
		}
	}
}
