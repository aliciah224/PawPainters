using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWallSection : MonoBehaviour
{
    public GameObject[] section;
    public bool creatingSection = false;
    public int secNum;


    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }

        IEnumerator GenerateSection()
        {
            secNum = Random.Range(0, 3);
            Instantiate(section[secNum], new Vector3(0, 50, 0), Quaternion.identity);
            yield return new WaitForSeconds(7);
            creatingSection = false;

        }







    }




}
