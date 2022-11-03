using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsantiateBlocks : MonoBehaviour
{
    [SerializeField] GameObject ClickBlock;
    [SerializeField] GameObject PushBlocks;
    [SerializeField] float TimeClickBlock = 1f;
   [SerializeField] float TimePushBlocks = 1.5f;
   [SerializeField] float addTime = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        TimeClickBlock = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TimeClickBlock)
        {
          Instantiate(ClickBlock, new Vector3(Random.Range(-8.509f, 9.94f), 5.85f, 0), Quaternion.Euler(0, 0, 0));
            TimeClickBlock = Time.time + addTime;
         
        }

        if(Time.time > TimePushBlocks)
        {

            Instantiate(PushBlocks, new Vector3(Random.Range(-8.509f, 9.94f), 5.85f, 0), Quaternion.Euler(0, 0, 0));
            TimePushBlocks = Time.time + addTime;
        }
    }
}
