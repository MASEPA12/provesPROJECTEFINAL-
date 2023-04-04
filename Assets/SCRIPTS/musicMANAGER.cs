using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicMANAGER : MonoBehaviour
{
    public Camera cam;
    public AudioSource _audioSource;
    public float volume;

    void Start()
    {
        //volume = GetComponent<AudioSource>().volume;
        _audioSource = cam.GetComponent<AudioSource>();
        //volume = _audioSource.volume;
    }

    public void VolumeSlider(float volumen)
    {
        _audioSource.volume = volumen;
    }
}
