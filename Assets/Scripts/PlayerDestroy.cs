using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour
{
    public GameObject bulletPrefab;
    public void ShotOnPlayer(Transform bulletSpawn)
    {
        Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
        bulletPrefab.transform.localScale = Vector3.one * 0.5f;
    }
}
