using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        if (player == null)
        {
            SceneManager.LoadScene(0);
        }
    }
}
