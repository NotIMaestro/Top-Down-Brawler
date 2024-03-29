using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemComponent : MonoBehaviour
{
    public Rigidbody rb;
    public event Action OnThrownEvent;
    public Collider col;
    public event Action OnItemUsed;


    public void UseItem()
    {
        OnItemUsed?.Invoke();
    }

    public void PickUp(Transform handToAttachTo)
    {
        col.enabled = false;

        rb.isKinematic = true;
        this.transform.SetParent(handToAttachTo);

        transform.localPosition = new Vector3(0, 0, 0);

    }


    // make a method called ThrowItem, it sets the rigidbody back to dynamic mode (kinematic = false) and it applies a force to the rigidbody
    // and unattaches it to our arm.

    public void ThrowItem(Vector3 throwDirection)
    {
        col.enabled = true;
        rb.isKinematic = false;
        this.transform.SetParent(null);
        rb.velocity = throwDirection * 10;

        OnThrownEvent?.Invoke();


    }

}
