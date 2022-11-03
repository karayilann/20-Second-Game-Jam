using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float m_Horizontal = Input.GetAxis("Horizontal");
        //float m_Vertical = Input.GetAxis("Vertical");

        Vector3 mover = new Vector3(m_Horizontal, 0, 0);
        rb.velocity = mover * speed ; 

    }
}
