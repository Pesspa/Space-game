using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Transform _playerTransform;
    private int _playerTriggerDamage;
    private void Start()
    {
        _playerTriggerDamage = FindObjectOfType<PlayerTrigger>().damage += 50;
    }
    void Update()
    {
        _playerTransform = FindObjectOfType<Player>().transform;
        transform.position = Vector3.Lerp(transform.position, _playerTransform.position, Time.deltaTime * 15f);
    }
}
