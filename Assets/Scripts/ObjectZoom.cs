using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectZoom : MonoBehaviour
{
    public GameObject Object;

    private bool _ZoomIn;
    private bool _ZoomOut;

    public float Scale = 0.05f;
    void Update()
    {
        if (_ZoomIn)
        {
            Object.transform.localScale += new Vector3(Scale, Scale, Scale);
            _ZoomIn = false;
        }

        if (_ZoomOut)
        {
            Object.transform.localScale -= new Vector3(Scale, Scale, Scale);
            _ZoomOut = false;
        }
    }

    public void OnZoomIn()
    {
        _ZoomIn = true;
    }

    public void OnZoomOut()
    {
        _ZoomOut = true;
    }
}
