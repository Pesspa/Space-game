using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTarget : MonoBehaviour
{
    public Text bombCount;
    public Text winText;
    public int TargetBomb;
    void Update()
    {
        bombCount.text = "Осталось уничтожить бомб: " + TargetBomb;
        if(TargetBomb <= 0)
        {
            winText.enabled = true;
            winText.color = Color.yellow;
            winText.text = "Империя получила преимущество благодаря вам!";
            Time.timeScale = 0;
        }
    }
}
