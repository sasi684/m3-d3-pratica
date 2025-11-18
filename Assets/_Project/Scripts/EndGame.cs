using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private int playersArrived = 0;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playersArrived++;
        if(playersArrived >= 2)
            Debug.Log("Livello completato!");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playersArrived--;
    }
}
