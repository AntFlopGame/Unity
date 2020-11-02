using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reverse_Traffic_Light : MonoBehaviour
{
    private Light light;
    public GameObject cube;

    void Start()
    {
        
        light = GetComponent<Light>();
        StartCoroutine(Light_f());

    }
    void Trigger_Car1()
    {
        string buff = cube.GetComponent<Trigger>().Tag();

        int check = cube.GetComponent<Trigger>().check;
        if (buff == "Car1" && check == 1)
        {
            cube.GetComponent<Trigger>().check = 0;
            cube.GetComponent<Trigger>().Check();
            GameObject.FindGameObjectWithTag("Car1").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }

    //void Trigger_Car2()
    //{
    //    string buff = cube.GetComponent<TriggerCar2_1>().Tag();
    //
    //    int check = cube.GetComponent<TriggerCar2_1>().check;
    //    if (buff == "Car2" && check == 1)
    //    {
    //        cube.GetComponent<TriggerCar2_1>().check = 0;
    //        cube.GetComponent<TriggerCar2_1>().Check();
    //        GameObject.FindGameObjectWithTag("Car2").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    //    }
    //}
    IEnumerator Light_f()
    {
        while (true)
        {

            light.enabled = true;
            cube.GetComponent<BoxCollider>().enabled = false;
            Trigger_Car1();
            //Trigger_Car2();
            yield return new WaitForSeconds(7f);
            

            light.enabled = false;
            cube.GetComponent<BoxCollider>().enabled = true;
            yield return new WaitForSeconds(11f);
        }
    }
}
