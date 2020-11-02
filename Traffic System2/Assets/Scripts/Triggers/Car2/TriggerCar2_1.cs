﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCar2_1 : MonoBehaviour
{
    public int check;

    public void OnTriggerEnter(Collider Other)
    {
        
        if (Other.tag == "Car2")
        {
            check = 1;
            GameObject.FindGameObjectWithTag("Car2").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;

            Debug.Log("Платформа работает Триггер1 " + Other.tag);
        }



    }

    private string coll;

    public void OnTriggerStay(Collider Other)
    {
        
        if (Other.tag == "Car2")
        {

            coll = Other.tag;
            Debug.Log("Платформа еще работает Триггер1 " + coll);
        }

    }

    public void Check()
    {

        Debug.Log("Чекнулоссь Триггер1 " + check);
    }
    public string Tag()
    {

        return coll;

    }
}
