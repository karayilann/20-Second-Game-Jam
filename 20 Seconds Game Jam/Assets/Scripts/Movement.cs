using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody2D rb2D;
    [SerializeField] float speed;
    float notUsing = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
        rb2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float Horizontal = Input.GetAxis("Horizontal");

        Vector3 mover = new Vector3(Horizontal, notUsing, notUsing) * Time.deltaTime;
        rb2D.velocity = mover * speed ; 

    }
}
