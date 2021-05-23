using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemComponent : MonoBehaviour
{
    public Transform playerHand;
    public Transform mesh;

    public IGetInput anyInputComponent;

    private ItemComponent currentItem = null;

    public float pickUpRadius = 3f;

    public bool HasItem()
    {
        // if we have an item then return true
        return (currentItem != null);
    }

    private void Start()
    {
        anyInputComponent = gameObject.GetComponent<IGetInput>();
    }


    void Update()
    {

        bool shouldWeUseItem = anyInputComponent.ItemInput();

        if (shouldWeUseItem && currentItem == null)
        {
            TryToPickUpItems();
        }
        else if (shouldWeUseItem)
        {
            TryThrowItem();

        }

  
        
    }

    public void TryThrowItem()
    {
        
        if (currentItem != null)
        {
            currentItem.ThrowItem(mesh.transform.forward);
            currentItem = null;

        }

        
    }

    public void TryToPickUpItems()
    {
        RaycastHit[] HitColliders;

        HitColliders = Physics.SphereCastAll(transform.position, pickUpRadius, Vector3.down, 1f);

        for (int i = 0; i < HitColliders.Length; i++)
        {
            ItemComponent itemComponent = HitColliders[i].transform.GetComponent<ItemComponent>();

            if (itemComponent != null)
            {
                currentItem = itemComponent;
                itemComponent.PickUp(playerHand);
            }


        }

    }


}
