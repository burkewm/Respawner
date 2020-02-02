using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SqMag : MonoBehaviour
{
    public Transform other;
    public float closeDistance = 0f;

    // Update is called once per frame
    void Update()
    {
        if (other)
        {
            Vector3 offset = other.position - transform.position;
            float sqrLen = offset.sqrMagnitude;


            if (sqrLen > closeDistance * closeDistance)
            {
                Debug.Log("Arrow Removed");
            }
        }
    }
}
