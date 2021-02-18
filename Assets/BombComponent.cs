using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombComponent : MonoBehaviour
{

    public float t = 3f;

    public float radius = 5f;


    // Update is called once per frame
    void Update()
    {
        t -= Time.deltaTime;

        if (t <= 0)
        {
            t = 0;


            Explode();
        }


        
    }

    private void Explode()
    {
        RaycastHit[] HitColliders;

        HitColliders = Physics.SphereCastAll(transform.position, radius, Vector3.down, 1f);

        for (int i = 0; i < HitColliders.Length; i++)
        {
            Debug.Log(HitColliders[i].transform.name + "GOT EXPLODED");

            if (HitColliders[i].transform.CompareTag("Player"))
            {
                Destroy(HitColliders[i].transform.gameObject);
            }
        }

        Destroy(transform.gameObject);

    }
}
