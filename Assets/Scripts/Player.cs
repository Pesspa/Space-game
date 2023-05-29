using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody playerBody;
    public float speedMove;
    public float speedRotate;

    private float _verttical;
    private float _horizontal;

    public Text healthText;
    public float health;

    public Transform visualTransform;
    private void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
        visualTransform.rotation = Quaternion.Lerp(visualTransform.rotation, Quaternion.LookRotation(playerBody.velocity), Time.deltaTime * 5f);

        Move();
    }
    private void Update()
    {
        if(health<= 0)
        {
            Destroy(gameObject);
        }
        healthText.text = "Прочность: " + health.ToString();
    }
    private void Move()
    {
        _horizontal = Input.GetAxis("Horizontal");
        playerBody.AddForce(transform.forward * speedMove * _horizontal, ForceMode.VelocityChange);

        _verttical = Input.GetAxis("Vertical");
        playerBody.AddForce(transform.up * speedRotate * _verttical, ForceMode.VelocityChange);
    }
}