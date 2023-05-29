using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    private void Awake()
    {
        transform.Rotate(new Vector3(0f, 90f, 0f));
    }
    void Update()
    {
        transform.localScale = Vector3.one * 0.3f * (Mathf.Sin(Time.time * 2f) * 0.05f + 0.5f);
    }
}

