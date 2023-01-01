using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadGen : MonoBehaviour
{
    public Material mat;

    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        mesh.vertices = new Vector3[]{
            new Vector3 (-1.2f, -1.2f,0),
            new Vector3 (-1.2f, 1.2f,0),
            new Vector3 (1.2f, -1.2f,0),
            new Vector3 (1.2f, 1.2f,0),
        };

        mesh.uv = new Vector2[]{
            new Vector3(0, 0),
            new Vector3(0, 1),
            new Vector3(1, 0),
            new Vector3(1, 1),
        };

        mesh.triangles = new int[]{
            0, 1, 2, 
            1, 3, 2,
        };

        GetComponent<MeshFilter>().sharedMesh = mesh;
        GetComponent<MeshRenderer>().material = mat;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
