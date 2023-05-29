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
        bombCount.text = "�������� ���������� ����: " + TargetBomb;
        if(TargetBomb <= 0)
        {
            winText.enabled = true;
            winText.color = Color.yellow;
            winText.text = "������� �������� ������������ ��������� ���!";
            Time.timeScale = 0;
        }
    }
}
