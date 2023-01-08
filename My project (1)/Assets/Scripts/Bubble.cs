using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    
    public GameObject platformPathStart;
    public GameObject platformPathEnd;
    public Vector3 startPosition;
    public Vector3 endPosition;
    public int speed;
    public Transform bubble;

    private SpriteRenderer spriteRenderer;

    public float timeRemaining = 3;

    public bool timerIsRunning = false;
    
       

    private void Start()
    {
      startPosition = platformPathStart.transform.position;
      endPosition = platformPathEnd.transform.position; 
      spriteRenderer = GetComponent<SpriteRenderer>();

    }
    

    // Update is called once per frame
    void Update()
    {
       MoveTowardPoint();
       if (timerIsRunning) {
        runTimer();
       }
    } 

    void MoveTowardPoint(){
        bubble.position = Vector2.MoveTowards(bubble.position, endPosition, Time.deltaTime*speed);
     }

void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("contact bubble");
        
        col.gameObject.transform.SetParent(gameObject.transform,true);
        spriteRenderer.color = new Color(255f, 255f, 0f, 1f);
        timerIsRunning = true;
}

void OnCollisionExit2D(Collision2D col)
    {
        col.gameObject.transform.parent = null;
    }


void runTimer(){

       if (timeRemaining > 0){
                timeRemaining -= Time.deltaTime;
            } else {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                Destroy(gameObject);
            }
}

    }


