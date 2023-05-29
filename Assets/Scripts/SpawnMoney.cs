using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMoney : MonoBehaviour
{
    public GameObject MoneyObj;

    private float _zClamp;
    private float _yClamp;
    private void Awake()
    {
        StartCoroutine(spawnBomb());
    }
    IEnumerator spawnBomb()
    {
        for (int i = 0; i < Mathf.Infinity; i++)
        {
            _zClamp = Random.Range(-38f, 38f);
            _yClamp = Random.Range(-16f, 16f);
            Instantiate(MoneyObj, new Vector3(0, _yClamp, _zClamp), Quaternion.identity);
            yield return new WaitForSeconds(1.5f);
        }
    }
}
