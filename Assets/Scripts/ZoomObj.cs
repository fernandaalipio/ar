using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomObj : MonoBehaviour
{
    public GameObject objects;

    private bool _zoomIn;
    private bool _zoomOut;

    //object scale speed
    public float scale = 0.1f;

    private void Update()
    {
        if (_zoomIn)
        {
            objects.transform.localScale += new Vector3(scale, scale, scale);
        }
        if (_zoomOut)
        {
            objects.transform.localScale -= new Vector3(scale, scale, scale);
        }
    }

    public void OnPressZoomIn()
    {
        objects.transform.localScale += new Vector3(scale, scale, scale);
        _zoomIn = true;
    }

    public void OnReleaseZoomIn()
    {
        objects.transform.localScale += new Vector3(scale, scale, scale);
        _zoomIn = false;
    }

    public void OnPressZoomOut()
    {
        objects.transform.localScale -= new Vector3(scale, scale, scale);
        _zoomOut = true;
    }

    public void OnReleaseZoomOut()
    {
        objects.transform.localScale -= new Vector3(scale, scale, scale);
        _zoomOut = false;
    }
}
