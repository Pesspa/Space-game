using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameTarget gameTarget;
    public float bulletSpeed;
    public Rigidbody rb;
    [SerializeField] private AudioSource allSource; 
    [SerializeField] private float _lifeTimeOfBullet = 3f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        { 
            Destroy(other.gameObject);
            gameTarget.TargetBomb--;
        }
    }
    void Start()
    {
        gameTarget = FindObjectOfType<GameTarget>();
        transform.localScale = Vector3.one / 10;
        rb.AddForce(transform.forward * bulletSpeed * Time.deltaTime, ForceMode.VelocityChange);
    }
    private void Update()
    {
        _lifeTimeOfBullet -= Time.deltaTime;
        if (_lifeTimeOfBullet < 0)
        {
            Destroy(gameObject);
        }
    }
}
