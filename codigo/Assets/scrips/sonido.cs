using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class sonido : MonoBehaviour
{
    [SerializeField] private  AudioMixer audioMixer;

    public void controlmusica(float sliderMusica) 
    {
        audioMixer.SetFloat("parametro", Mathf.Log10(sliderMusica) * 20);
    }

}