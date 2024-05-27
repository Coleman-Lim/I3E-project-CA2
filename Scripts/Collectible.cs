using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public virtual void Collected(StarterAssets.FirstPersonController player)
    { 
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject); 
        }
        
    }
    
}
