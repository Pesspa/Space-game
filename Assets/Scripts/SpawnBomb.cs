using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBomb : MonoBehaviour
{
    public GameObject spawnObject;

    private float _zClamp;
    private float _yClamp;
    private void Awake()
    {
        StartCoroutine(spawnBomb());
    }
    IEnumerator spawnBomb() {
        for (int i = 0; i < Mathf.Infinity; i++)
        {
            _zClamp = Random.Range(-40f, 40f);
            _yClamp = Random.Range(-16f, 16f);
            Instantiate(spawnObject, new Vector3(0, _yClamp, _zClamp), Quaternion.identity);
            yield return new WaitForSeconds(0.4f);
        }
    }
}
