using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D w)
    {
        if (w.gameObject.tag == "W")
        {
            if (Input.GetKey(KeyCode.W))
            { Destroy(w.gameObject); }
        }
    }
}
