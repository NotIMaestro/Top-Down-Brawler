using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIInputComponent : MonoBehaviour, IGetInput
{

    public MovementController movementController;

    public ItemComponent searchItem;

    public UseItemComponent useItem;

    public PlayerInputComponent playerGameObject;

    bool done = false;

    private void Start()
    {
        useItem = GetComponent<UseItemComponent>();

        if (searchItem == null)
        {
            searchItem = FindObjectOfType<ItemComponent>();
        }

        if (playerGameObject == null)
        {
            playerGameObject = FindObjectOfType<PlayerInputComponent>();
        }


    }

    public bool ItemInput()
    {

        if (done)
        {
            return false;
        }


        float radius = useItem.pickUpRadius;
        float distaceToObject = (searchItem.transform.position - transform.position).magnitude;

        if (distaceToObject < radius && useItem.HasItem() == false)
        {
            return true;
        }

        float distanceToPlayer = (playerGameObject.transform.position - transform.position).magnitude;

        if (distanceToPlayer < 4f && useItem.HasItem())
        {
            done = true;
            return true;
        }


        return false;
    }

    public bool JumpInput()
    {
        return false;
    }

    public Vector2 MovementVector()
    {

        if (done)
        {
            return Vector2.zero;
        }



        if (useItem.HasItem() == false)
        {
            var direction = searchItem.transform.position - transform.position;

            direction.y = 0;

            direction.Normalize();

            Vector3 input = new Vector2(direction.x, direction.z);


            return input;

        }
        else
        {
            var direction = playerGameObject.transform.position - transform.position;

            direction.y = 0;

            direction.Normalize();

            Vector3 input = new Vector2(direction.x, direction.z);


            return input;

        }


    }

}
