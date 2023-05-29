using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject hp;

    private void Awake()
    {
        StartCoroutine(SpawnNewHp());
    }
    IEnumerator SpawnNewHp()
    {
        for (int i = 0; i < Mathf.Infinity; i++)
        {
            float _zClam = Random.Range(-38f, 38f);
            float _yClam = Random.Range(-16f, 16f);
            Instantiate(hp, new Vector3(0, _yClam, _zClam), Quaternion.Euler(new Vector3(0f, 90f, 0f)));
            yield return new WaitForSeconds(20f);
        }
    }
}
