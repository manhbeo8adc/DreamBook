using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
{
    [SerializeField]
    private AudioSource m_AudioSource; //music audioSource

    void Start()
    {
        transform.Find("SoundSlider").GetComponent<Slider>().onValueChanged.AddListener((float value) =>
        {
            
        });
        transform.Find("MusicSlider").GetComponent<Slider>().onValueChanged.AddListener((float value) =>
        {
            m_AudioSource.volume = value;
        });
    }
}
