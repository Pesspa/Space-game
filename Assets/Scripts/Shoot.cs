using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public AudioSource sourceBlaster;
    public GameObject bullet;
    public GameObject[] spawnPos;
    private float timeBtwShoot = 0.2f;
    private float timer;
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (Input.GetMouseButton(0))
        {
            if(timer > timeBtwShoot) {
                for (int i = 0; i < spawnPos.Length; i++)
                {
                    timer = 0;
                    Instantiate(bullet, spawnPos[i].transform.position, spawnPos[i].transform.rotation);
                }
                sourceBlaster.Play();
                sourceBlaster.pitch = Random.Range(1.0f, 1.4f);
            }
        }
    }
}
