using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    public GameObject wallSection;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WallTrigger"))
        {
            collision.GetComponent<BoxCollider2D>().enabled = false;

            Instantiate(wallSection, new Vector3(0, 15, 0), Quaternion.identity);
            Debug.Log("Trigger Hit!");
        }
    }
}
