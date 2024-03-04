using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject parent;
    public GameObject restartButton;
    public GameObject quitGameButton;
    public GameObject dryFoodCount;
    public GameObject cannedTunaCount; 



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
