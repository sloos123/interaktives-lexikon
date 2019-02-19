using System.Collections;
using System.Collections.Generic;
using GoogleARCore;
using UnityEngine;

public class AugmentedImageVisualizer : MonoBehaviour
{
    public AugmentedImage Image;

    public GameObject TestObject;

    void Update()
    {
        if (Image == null || Image.TrackingState != TrackingState.Tracking)
        {
            TestObject.SetActive(false);
        }

        TestObject.SetActive(true);
    }
}
