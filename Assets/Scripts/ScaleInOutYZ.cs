﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleInOutYZ : MonoBehaviour
{
   public GameObject Object;

    private bool _ZoomIn;
    private bool _ZoomOut;

    //object scale speed
    public float Scale = 0.01f;

    // Update is called once per frame
    void Update()
    {
        if (_ZoomIn)
        {
            //make a bigger object
            Object.transform.localScale += new Vector3(0, Scale, Scale);
        }

        if (_ZoomOut)
        {
            //make a small object
            Object.transform.localScale -= new Vector3(0, Scale, Scale);
        }
    }

    //Make object scaled big
    public void OnPressZoomIn()
    {
        _ZoomIn = true;
    }

    public void OnReleaseZoomIn()
    {
        _ZoomIn = false;
    }

    //Make object scaled small
    public void OnPressZoomOut()
    {
        _ZoomOut = true;
    }

    public void OnReleaseZoomOut()
    {
        _ZoomOut = false;
    }
}
