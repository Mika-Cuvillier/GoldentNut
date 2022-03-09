using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private float input;
    public float jump;



    Rigidbody2D rb;
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
       anim = GetComponent<Animator>();
       rb = GetComponent<Rigidbody2D>(); 

    
    }


    private void Update()
    {
        if (input !=0) 
        {
            anim.SetBool("isRunning", true);
        }
        else {
            anim.SetBool("isRunning", false);
        }

        if (input > 0) {
            transform.eulerAngles = new Vector3(0, 0, 0);
        } 
        else if (input <0) {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetKeyDown("space")) {
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }


    }

    // Update is called once per frame
    void FixedUpdate()
    {
         input = Input.GetAxisRaw("Horizontal");

        print(input + "Horizontal");
       

        //Moving player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    }
}
