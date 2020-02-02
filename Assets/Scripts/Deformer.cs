using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(Rigidbody))]
public class Deformer : MonoBehaviour
{
    Mesh deformingMesh;
    Vector3[] originalVertices, displacedVertices, vertexVelocities;
    public float damping = 5f;
    public float forceOffset = 0.1f;
    private MeshCollider meshCollider;
    private bool hittable = true;
    private bool changed = false;
    private float uniformScale = 1f;

    private void Awake()
    {
        meshCollider = GetComponent<MeshCollider>();
        meshCollider.convex = true;
        meshCollider.sharedMesh = deformingMesh;
        deformingMesh = GetComponent<MeshFilter>().mesh;
        meshCollider.sharedMesh = deformingMesh;
        originalVertices = deformingMesh.vertices;
        displacedVertices = new Vector3[originalVertices.Length];
        vertexVelocities = new Vector3[originalVertices.Length];

        for (int i = 0; i < originalVertices.Length; i++)
        {
            displacedVertices[i] = originalVertices[i];
        }


    }

    public void AddDeformingForce(Vector3 point, float force)
    {
        point = transform.InverseTransformPoint(point);
        for (int i = 0; i < displacedVertices.Length; i++)
        {
            AddForceToVertex(i, point, force);
        }
    }

    private void AddForceToVertex(int i, Vector3 point, float force)
    {
        Vector3 pointToVertex = displacedVertices[i] - point;
        pointToVertex *= uniformScale;
        float attenuatedForce = force / (1f + pointToVertex.sqrMagnitude);
        float velocity = attenuatedForce * Time.deltaTime;
        vertexVelocities[i] += pointToVertex.normalized * velocity;
    }

    private void Update()
    {
        uniformScale = transform.localScale.x;

        if (changed)
        {
            for (int i = 0; i < displacedVertices.Length; i++)
            {
                UpdateVertex(i);
            }
            deformingMesh.vertices = displacedVertices;
            deformingMesh.RecalculateNormals();
            meshCollider.sharedMesh = null;
            meshCollider.sharedMesh = deformingMesh;
            changed = false;
        }
    }

    private void UpdateVertex(int i)
    {
        Vector3 velocity = vertexVelocities[i];
        velocity *= 1f - damping * Time.deltaTime;
        vertexVelocities[i] = velocity;
        displacedVertices[i] += velocity * Time.deltaTime;

    }

    private IEnumerator updateMeshCollidor()
    {
        meshCollider.sharedMesh = null;
        meshCollider.sharedMesh = deformingMesh;

        yield return new WaitForSeconds(.1f);
    }

    private IEnumerator sethittable()
    {
        hittable = true;
        yield return new WaitForSeconds(1.5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (hittable)
        {
            foreach (ContactPoint contact in collision.contacts)
            {
                if (contact.otherCollider.gameObject.tag == "hammer")
                {
                    changed = true;
                    float force = 100;
                    AddDeformingForce(contact.point.normalized, force);
                    StartCoroutine("updateMeshCollidor");
                    hittable = false;
                    StartCoroutine("sethittable");
                }
            }
        }
    }

    public void StartingDamage()
    {
        int contactPointIndex = Random.Range(0, deformingMesh.vertices.Length - 1);
        Vector3 point = deformingMesh.vertices[contactPointIndex];
        float force = 90;
        int numDamagePoints = Random.Range(0, 3);

        for (int i = 0; i < numDamagePoints; i++)
        {
            AddDeformingForce(point, force);
        }

    }
}
