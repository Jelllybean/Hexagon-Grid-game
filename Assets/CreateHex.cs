using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHex : MonoBehaviour
{
    private LineRenderer lineRenderer;
    Vector3[] newVertices;
    Vector2[] newUV;
    int[] newTriangles;

    private void Start()
    {

    }
    private void Update()
    {

        //for (int i = 0; i < 7; i++)
        //{
        //    lineRenderer.SetPosition(i, pointy_hex_corner(transform.position, 1f, i));
        //}

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;

        for (var i = 0; i < vertices.Length; i++)
        {
            vertices[i] += normals[i] * Mathf.Sin(Time.time);
        }

        mesh.vertices = vertices;

    }

    private void SpawnMesh()
    {

    }

    private Vector3 pointy_hex_corner(Vector2 center, float size, float i)
    {
        var angle_deg = 60 * i - 30;
        var angle_rad = Mathf.PI / 180 * angle_deg;
        return new Vector3(center.x + size * Mathf.Cos(angle_rad), 0,
                     center.y + size * Mathf.Sin(angle_rad));
    }
}
