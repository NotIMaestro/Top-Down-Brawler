using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceComponent : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {

        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            ResourceInventory inventoryComponent = other.GetComponent<ResourceInventory>();

            if (inventoryComponent != null)
            {
                inventoryComponent.numberOfCoal++;
                
                Destroy(gameObject);
            }
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
