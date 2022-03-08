using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float inputH = Input.GetAxisRaw("Horizontal");

        print(inputH + "Horizontal");
       

        //Moving player
        rb.velocity = new Vector2(inputH * speed, rb.velocity.y);
    }
}
