using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ResourceInventory : MonoBehaviour
{

    public int numberOfCoal = 0;
    public GameObject coalObject;


    public PlayerInputComponent controller;

    private InputAction dropItemInput;

    private void Start()
    {
        dropItemInput = controller.controls.Control.Dropitem;
    }

    public void SpawnObject()
    {
        if (numberOfCoal > 0)
        {
            Instantiate(coalObject, transform.position + transform.forward.normalized * 3, Quaternion.identity);
            numberOfCoal--;
        }
    }

    private void Update()
    {
        if (dropItemInput.triggered)
        {
            SpawnObject();
        }
    }




}
