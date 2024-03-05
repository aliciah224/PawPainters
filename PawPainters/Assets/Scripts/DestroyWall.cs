using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    public GameObject wallSection;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {

            Destroy(this.gameObject);


            Debug.Log("Wall Section had gone too far and been destroyed");
       
    }
}
