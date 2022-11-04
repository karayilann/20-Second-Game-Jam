using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D w)
    {
        if(w.gameObject.tag == "W")
        {
            Debug.Log("w");
        }

        if (w.gameObject.tag == "Click")
        {
            Debug.Log("Click");
        }
    }
}
