using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCar2_2 : MonoBehaviour
{
    public int check;

    public void OnTriggerEnter(Collider Other)
    {
       
        if (Other.tag == "Car2")
        {
            check = 2;
            GameObject.FindGameObjectWithTag("Car2").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX;
            Debug.Log("Платформа работает Триггер2 " + Other.tag);
        }


    }

    private string coll;

    public void OnTriggerStay(Collider Other)
    {
        
        if (Other.tag == "Car2")
        {

            coll = Other.tag;
            Debug.Log("Платформа еще работает Триггер2 " + coll);
        }


    }

    public void Check()
    {

        Debug.Log("Чекнулоссь Триггер2 " + check);
    }
    public string Tag()
    {

        return coll;

    }
}
