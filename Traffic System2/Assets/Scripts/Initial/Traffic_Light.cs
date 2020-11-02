using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic_Light : MonoBehaviour
{
    private Light light;
    
    void Start()
    {
        
        light = GetComponent<Light>();
        StartCoroutine(Light_f());
        
    }
    IEnumerator Light_f()
    {
        while (true)
        {

            light.enabled = true;
            yield return new WaitForSeconds(7f);

            light.enabled = false;
            yield return new WaitForSeconds(11f);
        }
    }
  
    
}
