using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    //SpawnWallVar
    public GameObject[] section;
    public int secNum;
    //Vector3 wallCoords = new Vector3(0, 20, 0);

    public GameObject spawnTrigger;
    [System.NonSerialized]
    public GameObject spawnEdge;
    public GameObject wallSectionEdge;


    private void Start()
    {
        spawnEdge = GameObject.Find("SpawnEdge");
        wallSectionEdge = GameObject.Find("WallSectionEdge");

    }

    void Update()

    {
        if (gameObject.tag == "WallSections" || gameObject.tag == "EnableTrigger" || gameObject.tag == "WallTrigger")
        {
            transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
           // Debug.Log("Wall Section is moving)");
        }

        if(spawnTrigger != null)
        {
            if (Vector3.Distance(spawnTrigger.transform.position, spawnEdge.transform.position) < 20.0f)
            {
                SpawnWall();
            }
        }

       // Debug.Log((Vector3.Distance(spawnEdge.transform.position, wallSectionEdge.transform.position)));

       
        
    }
    public void SpawnWall()
    {
        Destroy(spawnTrigger);
        Debug.Log("CoolBeans");

        secNum = UnityEngine.Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 54, 0), Quaternion.identity);

    }



}
