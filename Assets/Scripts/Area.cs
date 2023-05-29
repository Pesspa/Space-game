using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Area : MonoBehaviour
{
    public GameObject area;
    private void Awake()
    {
        
        area.SetActive(false);
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("GameArea"))
        {
            area.SetActive(true);
        }
        
    }
}
