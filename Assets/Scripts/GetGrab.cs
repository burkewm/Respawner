using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetGrab : MonoBehaviour
{

    public GameObject hoveredObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interact"))
        {
            hoveredObj = other.gameObject;
        }
    }
}
