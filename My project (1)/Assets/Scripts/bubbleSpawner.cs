using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleSpawner : MonoBehaviour
{

    public Bubble bubblePrefab;
    private float timeRemaining = 5;
    // Start is called before the first frame update
    void Start()
    {
        
         Spawn();
    
    }
    public void Spawn(){

         Bubble bubble = Instantiate(bubblePrefab, transform.localPosition, Quaternion.identity);

    }
    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0){
            timeRemaining -= Time.deltaTime;
        } else {
            timeRemaining = 5;
            Spawn();
        }
    }
}
