using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    public GameObject wallSection;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WallTrigger"))
        {
            Instantiate(wallSection, new Vector3(0, 15, 0), Quaternion.identity);
            Debug.Log("Trigger Hit!");
        }
    }
}
