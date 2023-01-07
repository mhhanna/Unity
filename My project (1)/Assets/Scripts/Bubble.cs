using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    
    public GameObject platformPathStart;
    public GameObject platformPathEnd;
    private Vector3 startPosition;
    private Vector3 endPosition;
    public int speed;
    public Transform bubble;
    
    
    

    private void Start()
    {
      startPosition = platformPathStart.transform.position;
      endPosition = platformPathEnd.transform.position; 
    }
    

    // Update is called once per frame
    void Update()
    {
       MoveTowardPoint();
    } 

    void MoveTowardPoint(){
        bubble.position = Vector2.MoveTowards(bubble.position, endPosition, Time.deltaTime*speed);
       

    }

void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("contact bubble");
        
        col.gameObject.transform.SetParent(gameObject.transform,true);
}

void OnCollisionExit2D(Collision2D col)
    {
        col.gameObject.transform.parent = null;
    }

    }


