using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombComponent : MonoBehaviour
{
    [SerializeField]
    private bool activated = false;

    public float timer = 3f;
    public float radius = 5f;

    public void Activate()
    {
        activated = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (activated == false)
        {
            return;
        }


        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 0;


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
