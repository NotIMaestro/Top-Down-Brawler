using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunComponent : MonoBehaviour
{

    public ItemComponent item; // listen to this

    void Start()
    {
        item.OnItemUsed += ShootGun;
    }

    private void ShootGun()
    {
        Debug.Log("Shot!");

    }
}
