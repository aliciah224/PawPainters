using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject parent;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            parent.SetActive(true);
            Time.timeScale = 0;


            Debug.Log("Player has lost");
        }
    }
}
