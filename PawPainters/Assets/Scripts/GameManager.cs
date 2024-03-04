using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;

       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("StartingButton");
            foreach (GameObject target in gameObjects)
            {
                GameObject.Destroy(target);

            }


        }
    }
}
