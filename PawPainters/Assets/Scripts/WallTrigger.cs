using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    public GameObject wallSection;
    public GameObject loseTrigger;

    public float interval = 3;
    float timer;

    //Bools
    private bool wallSpawned;



    public GameObject parent;


    void Update()
    {

    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LoseTrigger"))
        {
            Debug.Log("Lose collision");

            
            parent.SetActive(false);
         
           

            Debug.Log("Player has lost");
        }
    }

   
     


}