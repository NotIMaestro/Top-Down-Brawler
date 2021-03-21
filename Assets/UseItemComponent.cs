using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemComponent : MonoBehaviour
{
    public Transform playerHand;

    public MovementController controlReference;
    private PlayerMovement controls;

    private ItemComponent currentItem = null;


    void Start()
    {

        controls = controlReference.controls;
        
    }

    void Update()
    {

        var itemInput = controls.Control.UsePickup;

        if (itemInput.triggered && currentItem == null)
        {
            TryToPickUpItems();
            

        }
        else if (itemInput.triggered && currentItem != null)
        {
            currentItem.ThrowItem(Vector3.forward);
            currentItem = null;

        }

  
        
    }

    public void TryToPickUpItems()
    {
        RaycastHit[] HitColliders;

        HitColliders = Physics.SphereCastAll(transform.position, 3f, Vector3.down, 1f);

        for (int i = 0; i < HitColliders.Length; i++)
        {
            var itemComponent = HitColliders[i].transform.GetComponent<ItemComponent>();

            if (itemComponent != null)
            {
                currentItem = itemComponent;
                itemComponent.PickUp(playerHand);
            }


        }

    }


}
