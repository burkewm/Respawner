using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catcher : MonoBehaviour
{

    public Transform spawnpoint;
    private GameObject item;

    private void OnCollisionEnter(Collision collision)
    {
        item = collision.contacts[0].otherCollider.gameObject;
        var newitem = Instantiate(item, spawnpoint);
        Destroy(item);
    }
}
