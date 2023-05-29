using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPlace : MonoBehaviour
{
    private bool isShooted;
    private Transform _placeAtShot;
    public GameObject[] deathSpawns;
    private float _timer = 5;
    public PlayerDestroy playerDestroy;

    private float _minDistance = Mathf.Infinity;
    public Image warningScreen;
    public Text warningText;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Area") == true)
        {
            warningScreen.enabled = false;
            warningText.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        _timer = 5f;
        warningScreen.enabled = true;
        warningText.enabled = true;
    }
    private void Start()
    {
        isShooted = false;
    }
    void Update()
    {
        if (warningScreen.enabled == true)
        {
            _timer -= Time.deltaTime;
            warningText.text = "Вражеский крейсер наводится на вас! " + _timer.ToString("0.00");
            if (_timer <= 0f)
            {
                warningText.text = "Вражеский крейсер наводится на вас! ";
                if (!isShooted)
                {
                    for (int i = 0; i < deathSpawns.Length; i++)
                    {
                        if (Vector3.Distance(transform.position, deathSpawns[i].transform.position) < _minDistance)
                        {
                            _minDistance = Vector3.Distance(transform.position, deathSpawns[i].transform.position);
                            _placeAtShot = deathSpawns[i].transform;
                        }
                    }
                    playerDestroy.ShotOnPlayer(_placeAtShot);
                    isShooted = true;
                }
            }
        }
    }
}
