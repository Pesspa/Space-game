using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField] private AudioClip explosionClip;
    [SerializeField] private AudioClip healthClip;
    public int damage;
    public AudioSource audioSource;
    private Player _playerObject;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            _playerObject.health -= damage;
            audioSource.clip = explosionClip;
            audioSource.Play();
            Destroy(other.gameObject);

        }
        if (other.gameObject.CompareTag("Coin"))
        {
            _playerObject.health++;
            audioSource.clip = healthClip; 
            audioSource.Play();
            Destroy(other.gameObject);
        }
    }
    private void Start()
    {
        _playerObject = gameObject.GetComponent<Player>();
    }
}
