using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    public GameObject wallSection;
    public GameObject[] section;
    public int secNum;

    public GameObject[] triggersection;
    public int triggersecNum;

    public GameObject[] walltriggersection;
    public int walltriggersectionNum;




    public bool alreadyTriggered = false;
    public GameObject box2DTrigger;
    public GameObject enableTrigger;
    




    //Function to destory enableTrigger
    void DestroyenableTrigger()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("EnableTrigger");
        foreach (GameObject target in gameObjects)
        {
            GameObject.Destroy(target);
            
        }

        Debug.Log("Enable Trigger has been destroyed");
    }




    //Function to destory wallTrigger
    void Destroybox2DTrigger()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("WallTrigger");
        foreach (GameObject target in gameObjects)
        {
            GameObject.Destroy(target);

        }
        Debug.Log("Wall Trigger has been destroyed");
    }




    //Function to instantiate wall trigger 
    void Spawnbox2DTrigger()
    {
        Instantiate(walltriggersection[walltriggersectionNum], new Vector3(0, 45, 0), Quaternion.identity);
        Debug.Log("Wall Trigger has been instantiated");
    }

    //Function to instantiate enableTrigger
    void SpawnenableTrigger()
    {
        Instantiate(triggersection[triggersecNum], new Vector3(0, 25, 0), Quaternion.identity);
        Debug.Log("Enable Trigger has been instantiated");
    }
    




    //On collision with wall trigger instantiates the next wall section as well as the next enable trigger and destorys wall trigger
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WallTrigger"))
        {
            
                secNum = UnityEngine.Random.Range(0, 3);
                Instantiate(section[secNum], new Vector3(0, 45, 0), Quaternion.identity);
               
               
                alreadyTriggered = true;

                Destroybox2DTrigger();
                SpawnenableTrigger();
            
        }


        //On collision with enbale trigger spawn wall trigger and destroy enable trigger
        if (collision.gameObject.CompareTag("EnableTrigger"))
        {
            if (alreadyTriggered == true)
            {
                
                DestroyenableTrigger();
                Spawnbox2DTrigger();
                
                    
            }

        }

          
        
    }
}