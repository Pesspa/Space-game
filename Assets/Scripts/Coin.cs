using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
    {
        transform.localScale = Vector2.one * 0.3f * (Mathf.Sin(Time.time * 2f) * 0.05f + 0.5f);
        
    }
}
