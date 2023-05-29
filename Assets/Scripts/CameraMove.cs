using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float scrollForce = 10f;
    public GameObject player;
    void Update()
    {
        transform.position = new Vector3(transform.position.x, player.transform.position.y, player.transform.position.z);

        float mousescrollWhile = Input.GetAxis("Mouse ScrollWheel") * scrollForce * Time.deltaTime;
        if (mousescrollWhile >= 10)
        {
            transform.Translate(transform.right * scrollForce * -mousescrollWhile);
        }                                           
        if (mousescrollWhile >= -10)                
        {                                           
            transform.Translate(transform.right * scrollForce * mousescrollWhile);
        }
    }
}
