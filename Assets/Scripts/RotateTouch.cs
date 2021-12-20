using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTouch : MonoBehaviour
{
    private float m_RotationSpeed = 20f;

    void Update()
    {
        if (1 == Input.touchCount)
        {
            gameObject.transform.Rotate(Vector3.down, Input.touches[0].deltaPosition.x * m_RotationSpeed * Time.deltaTime);
            gameObject.transform.Rotate(Vector3.right, Input.touches[0].deltaPosition.y * m_RotationSpeed * Time.deltaTime);
        }
    }
}
