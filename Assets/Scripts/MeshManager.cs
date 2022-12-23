using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshManager : MonoBehaviour
{
    private MeshFilter meshFilter;
    private Mesh myMesh;
    private Vector3[] myVertices = new Vector3[4];
    private int[] myTriangles = new int[6];
    private float width = 2;
    private float hight = 2;
 
    void Start()
    {
        meshFilter = gameObject.GetComponent<MeshFilter>();
        myMesh = new Mesh();
 
        myVertices[0] = new Vector3(0, 0, 0);
        myVertices[1] = new Vector3(width, 0, 0);
        myVertices[2] = new Vector3(0, hight, 0);
        myVertices[3] = new Vector3(width, hight, 0);
 
        myMesh.SetVertices(myVertices);
 
        myTriangles[0] = 0;
        myTriangles[1] = 2;
        myTriangles[2] = 1;
        myTriangles[3] = 2;
        myTriangles[4] = 3;
        myTriangles[5] = 1;
 
        myMesh.SetTriangles(myTriangles, 0);
 
        //MeshFilterへの割り当て
        meshFilter.mesh = myMesh;
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) //スペースキーの入力
        {
            for(int i = 0; i < myVertices.Length; i++)
            {
                //頂点をずらす
                myVertices[i] += new Vector3(Random.Range(-0.05f, 0.05f), Random.Range(-0.05f, 0.05f));
            }
            myMesh.SetVertices(myVertices);　//新しい頂点を割り当てる
 
        }
        
    }
}
