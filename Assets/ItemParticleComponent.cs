using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemParticleComponent : MonoBehaviour
{

    public ItemComponent item; // listen to this

    void Start()
    {
        item.OnItemUsed += PlayParticles;
    }

    private void PlayParticles()
    {
        Debug.Log("Particles Played");

    }
}
