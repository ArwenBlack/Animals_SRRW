using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LionTrigger : MonoBehaviour
{
    private float last_time = 0;
    void Start()
    {
        lights = GetComponentsInChildren<Light>();
        foreach (Light light in lights)
        {
            light.enabled = false;
        }
    }
    private Light[] lights;
    void OnTriggerEnter(Collider other)
    {
        lights = GetComponentsInChildren<Light>();
        foreach (Light light in lights)
        {
                light.enabled = true;
                light.color = Color.red;
          }
    }
    void OnTriggerStay(Collider other)
    {
        lights = GetComponentsInChildren<Light>();
        foreach (Light light in lights)
        {
            if (Time.time - last_time < 1)
                return;
                light.color = Color.red;
                light.enabled = !light.enabled;
                last_time = Time.time;
        }
    }
    void OnTriggerExit(Collider other)
    {
        lights = GetComponentsInChildren<Light>();
        foreach (Light light in lights)
        {
            light.enabled = false;
        }
        Debug.Log("Object exited trugger");
    }
}
