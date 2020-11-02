using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    public Vector3 lastMouse;
    public float camSens = 0.25f;
    float x, z;
    public float speed = 10f;

    void Update()
    {
        lastMouse = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
        lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
        transform.eulerAngles = lastMouse;
        z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        

        transform.Translate(new Vector3(x, 0, z));
    }
}
