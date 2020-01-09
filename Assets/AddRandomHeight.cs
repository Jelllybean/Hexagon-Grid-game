using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRandomHeight : MonoBehaviour
{
    //void Start()
    //{
    //    Mesh mesh = GetComponent<MeshFilter>().mesh;
    //    Vector3[] vertices = mesh.vertices;
    //    Vector3[] normals = mesh.normals;
    //
    //    for (int i = 0; i < vertices.Length; i++)
    //    {
    //        normals[i] = new Vector3(5, 0, 5);
    //    }
    //
    //    mesh.normals = normals;
    //}
    private void Update()
    {
        // obtain the normals from the Mesh
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] normals = mesh.normals;

        // edit the normals in an external array
        //Quaternion rotation = Quaternion.AngleAxis(Time.deltaTime * 5, Vector3.up);
        for (int i = 0; i < normals.Length; i++)
            normals[i] = new Vector3(Random.Range(0, 100), 0, Random.Range(0, 100));

        // assign the array of normals to the mesh
        mesh.normals = normals;
        mesh.RecalculateNormals();
    }
}
