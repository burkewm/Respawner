using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSkelly : MonoBehaviour
{
    public GameObject skel;
    Transform originTransform;
    // Start is called before the first frame update
    void Start()
    {
        originTransform = this.transform; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Interact")
        {
            SpawnSkeleton();
            this.transform.rotation = originTransform.rotation;
            this.transform.position = originTransform.position;
        }
    }

    public void SpawnSkeleton()
    {
        Instantiate(skel);
    }
}
