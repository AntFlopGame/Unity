using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic_Light2 : MonoBehaviour
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
        int check = cube.GetComponent<Trigger_2>().check;
        string buff = cube.GetComponent<Trigger_2>().Tag();
        if (buff == "Car1" && check == 2)
        {
            cube.GetComponent<Trigger_2>().check = 3;
            cube.GetComponent<Trigger_2>().Check();
            GameObject.FindGameObjectWithTag("Car1").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }

  // void Trigger_Car2()
  // {
  //     string buff = cube.GetComponent<TriggerCar2_2>().Tag();
  // 
  //     int check = cube.GetComponent<TriggerCar2_2>().check;
  //     if (buff == "Car2" && check == 1)
  //     {
  //         cube.GetComponent<TriggerCar2_2>().check = 0;
  //         cube.GetComponent<TriggerCar2_2>().Check();
  //         GameObject.FindGameObjectWithTag("Car2").GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
  //     }
  // }
    IEnumerator Light_f()
    {
        while (true)
        {

            light.enabled = false;
            cube.GetComponent<BoxCollider>().enabled = true;
            yield return new WaitForSeconds(9f);

            light.enabled = true;
            cube.GetComponent<BoxCollider>().enabled = false;
            Trigger_Car1();
            //Trigger_Car2();
            
                
           
            yield return new WaitForSeconds(7f);

            light.enabled = false;
            cube.GetComponent<BoxCollider>().enabled = true;
            yield return new WaitForSeconds(2f);

            
        }
    }
}
