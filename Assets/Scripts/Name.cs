using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Name : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    public int number = 0;
    public GameObject Target;
    public Text Textm;
    void Start()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Textm = Target.GetComponent<Text>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("MouseDown");
            // Reset ray with new mouse position
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Target = hit.collider.gameObject;
                Debug.Log(Target.name);
                if (Target.name != "Emulator Ground Plane")
                {
                    Textm.text = Target.name;
                }

            }

        }
    }
}
