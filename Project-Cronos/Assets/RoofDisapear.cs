using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoofDisapear : MonoBehaviour
{

    MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (meshRenderer.enabled)
            {
                meshRenderer.enabled = false;
            }

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (!meshRenderer.enabled)
            {
                meshRenderer.enabled = true;
            }

        }  
    }
}
