using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{

    public bool wallMoved = false;

    private void Start()
    {
        wallMoved = true;

        
    }

    // Update is called once per frame
    void Update()
    {
   
        

        if (wallMoved == true)
        {
            wallMove();
            Debug.Log("Wall has moved");

        }

    

        void wallMove()
            {
               transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
            }
        
            
        
        
    }
}
