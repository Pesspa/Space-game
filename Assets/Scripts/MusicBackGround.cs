using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBackGround : MonoBehaviour
{
    [SerializeField] AudioClip[] _backGroundMusic;
    [SerializeField] AudioSource _music;
    void Start()
    {
        _music.clip = _backGroundMusic[Random.Range(0, _backGroundMusic.Length)];
        _music.volume = 0.25f;
    }
    void Update()
    {
        if (!_music.isPlaying)
        {
            _music.clip = _backGroundMusic[Random.Range(0, _backGroundMusic.Length)];
            _music.Play();
        }
    }
}
