using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSectionSpawning : MonoBehaviour
{
    Vector3 wallCoords = new Vector3(0, 0, 0);
    public GameObject wallSection;
    public GameObject[] section;
    public int secNum;

    public GameObject[] walltriggersection;
    public int walltriggersectionNum;


    public bool gameLose = false;
    public GameObject parent;


    // Update is called once per frame
    void Update()
    {
        
        
            if(Vector3.Distance(transform.position, wallCoords) < 15.0f)
        {
            Instantiate(walltriggersection[walltriggersectionNum], new Vector3(0, 35, 0), Quaternion.identity);
            Debug.Log("Wall Trigger has been instantiated");
            Debug.Log("Distance below threshold");

        }

       

                
        
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Lose collision");


            parent.SetActive(false);



            Debug.Log("Player has lost");
        }
    }
}
