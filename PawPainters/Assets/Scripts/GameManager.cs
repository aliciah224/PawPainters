using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //SCRIPTS:
    [System.NonSerialized]
    public MainMenu menuManager;

    //public GameObject restartButton;
    //public GameObject quitGameButton;
    //public GameObject dryFoodCount;
    //public GameObject cannedTunaCount;

    [Header("UI Elements:")]
    [Space]
    public GameObject parent;
    public GameObject[] buttons;


    // Start is called before the first frame update
    void Start()
    {
        menuManager = GetComponent<MainMenu>();
        Time.timeScale = 0;  
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !parent.activeInHierarchy)
        {
            Time.timeScale = 1;
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("StartingButton");
            foreach (GameObject target in gameObjects)
            {
                GameObject.Destroy(target);

            }


        }
        else if (Input.GetKeyDown(KeyCode.Space) && parent.activeInHierarchy)
        {
            if(menuManager != null)
            {
                menuManager.Play();
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
