using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class WallMoveOther : MonoBehaviour
{
    public bool wallMoved = false;
    public GameObject[] wallSections;
    public bool starterWallMoved = false;


    private void Start()
    {
        starterWallMoved = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (starterWallMoved == false)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {

                wallMoved = true;
                starterWallMoved = true;


            }

        }
  



        if (wallMoved == true)
        {
            wallMove();
            //Debug.Log("Wall has moved");

        }



        void wallMove()
        {
            //GameObject[] wallSections = GameObject.FindGameObjectsWithTag("WallSections");
            //foreach (GameObject target in wallSections)
            
                transform.position += new Vector3(0, -1, 0) * Time.deltaTime;
               // Debug.Log("Wall is falling");

               
            
               
        }

        if (starterWallMoved == true)
        {
            wallMove();

        }


    }
}
