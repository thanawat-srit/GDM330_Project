using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(new Vector2(-0.1f,0),ForceMode2D.Impulse);
        }else if (Input.GetKey(KeyCode.D)){
            rb.AddForce(new Vector2(0.1f,0),ForceMode2D.Impulse);
        }
    }
}
