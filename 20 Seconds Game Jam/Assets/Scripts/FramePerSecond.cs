using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramePerSecond : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60; // Lock fps to 60
    }
}
