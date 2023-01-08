using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
public Rigidbody2D rb;

public string direction = "right";
public float jumpAmount = 4f;

public float speed = 1f;
void Update()
{
    if (Input.GetKeyDown(KeyCode.LeftArrow)){
        direction = "left";
    }

    if (Input.GetKeyDown(KeyCode.RightArrow)){
        direction = "right";
    }

    if (Input.GetKeyDown(KeyCode.Space))
    {
        rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);

        if (direction == "right") {
        rb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
        } else {
           rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse); 
        }
    }
        
}

 
}
