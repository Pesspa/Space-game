using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarPlane : MonoBehaviour
{
    public Rigidbody playerBody;
    public float speedMove;
    public float speedRotate;

    private float _vertical;
    private float _horizontal;

    public Text healthText;
    public float health;
    private void Awake()
    {
        playerBody = GetComponent<Rigidbody>();
        healthText.color = Color.blue;
    }

    void FixedUpdate()
    {
        _horizontal = Input.GetAxis("Horizontal");
        playerBody.AddForce(transform.forward * speedMove * _horizontal, ForceMode.VelocityChange);

        _vertical = Input.GetAxis("Vertical");
        playerBody.AddTorque(-transform.right * speedRotate * _vertical, ForceMode.VelocityChange);

        healthText.text = health.ToString();

    }
}
