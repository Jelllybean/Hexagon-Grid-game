using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class MeshCreator : MonoBehaviour
{
    public Vector3[] normals;
    public Vector3[] vertices = new Vector3[4];
    public Vector2[] uv = new Vector2[4];
    public int[] triangles = new int[6];
    private int x = 0;

    void Start()
    {
        //vertices[0] = new Vector3(0,1);
        //vertices[1] = new Vector3(1,1);
        //vertices[2] = new Vector3(0,0);
        //vertices[3] = new Vector3(1,0);

        //uv[0] = new Vector2(0,1);
        //uv[1] = new Vector2(1,1);
        //uv[2] = new Vector2(0,0);
        //uv[3] = new Vector2(1,0);

        //triangles[0] = 0;
        //triangles[1] = 1;
        //triangles[2] = 2;
        //triangles[3] = 2;
        //triangles[4] = 1;
        //triangles[5] = 3;

        SpawnMesh(new Vector3(0, 0, 0));


    }
    private void SpawnMesh(Vector3 newPosition)
    {
        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;
        mesh.normals = mesh.vertices;

        GameObject gameObject = new GameObject("Mesh", typeof(MeshFilter), typeof(MeshRenderer));
        gameObject.AddComponent<AddRandomHeight>();
        gameObject.transform.localScale = new Vector3(30, 1, 30);
        gameObject.transform.position = newPosition;

        gameObject.GetComponent<MeshFilter>().mesh = mesh;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SpawnMesh(new Vector3(0, 0, 0));
            SpawnMesh(new Vector3(30, 0, 45));
            SpawnMesh(new Vector3(60, 0, 0));
            SpawnMesh(new Vector3(30, 0, -45));
            SpawnMesh(new Vector3(-30, 0, -45));
            SpawnMesh(new Vector3(-60, 0, 0));
            SpawnMesh(new Vector3(-30, 0, 45));
            //for (int i = 0; i < 10; i++)
            //{
            //    SpawnMesh(new Vector3(i * -30, 0, i * -45));
            //    //x += 60;
            //}
        }
    }
}
