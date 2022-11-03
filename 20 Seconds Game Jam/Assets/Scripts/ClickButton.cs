using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    void Start()
    {

    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        Debug.Log("Destroyed");
    }
}
