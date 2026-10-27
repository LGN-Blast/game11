using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    bool hit = false;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit" + other);
        if (other.transform.root.CompareTag("Player"))
        {
            hit = true;
        }

    }

    void Update()
    {
        if (hit == true)    
        {
            Destroy(gameObject);
        }
        
    }
}
