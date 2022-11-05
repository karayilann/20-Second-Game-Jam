using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float timeLeft = 20f;
    int timerint = 20;
    [SerializeField] TMP_Text clock;
    
    void Update()
    {
        // timerint -= ((int)Time.deltaTime);
        
        int timerint = ((int)timeLeft);
        clock.text = timerint.ToString();

       
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                
            }

            if( timeLeft <= 0)
            {
            SceneManager.LoadScene("DidIt");

            }
        
    }
}
