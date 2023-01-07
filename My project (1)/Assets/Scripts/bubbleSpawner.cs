using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleSpawner : MonoBehaviour
{

    public Bubble bubblePrefab;
    // Start is called before the first frame update
    void Start()
    {
       for (int i = 0; i < 1; i++)
        {
           Spawn();
        }


    }
    public void Spawn(){

         Bubble bubble = Instantiate(bubblePrefab, transform.localPosition, Quaternion.identity);

       


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
