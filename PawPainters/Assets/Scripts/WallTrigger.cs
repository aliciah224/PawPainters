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
    public bool alreadyTriggered = false;
    public GameObject box2DTrigger;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WallTrigger"))
        {
            if(!alreadyTriggered)
            {
                secNum = UnityEngine.Random.Range(0, 3);
                Instantiate(section[secNum], new Vector3(0, 48, 0), Quaternion.identity);
                Debug.Log("Trigger Hit!");
                
            }


        }
            //collision.GetComponent<BoxCollider2D>().enabled = false;

           
        }
    }
}
