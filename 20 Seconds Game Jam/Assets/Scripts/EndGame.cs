using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D w)
    {
        if(w.gameObject.tag == "W")
        {
            SceneManager.LoadScene("EndGame");
        }

        if (w.gameObject.tag == "Click")
        {
            SceneManager.LoadScene("EndGame");
        }
    }
}
