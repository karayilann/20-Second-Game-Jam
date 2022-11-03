using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsantiateBlocks : MonoBehaviour
{
    [SerializeField] GameObject ClickBlock;
    [SerializeField] GameObject PushBlocks;
    float timepass = 1f;
    float addTime = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        timepass = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timepass)
        {
            Debug.Log("Worked");
            timepass = Time.time + addTime;
        }
    }
}
