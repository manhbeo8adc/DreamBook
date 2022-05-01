using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingBoard : MonoBehaviour
{
    public static SettingBoard instance;
    void Start()
    {
        instance = this;
        GetComponent<RectTransform>().localPosition = Vector3.zero;
        transform.Find("ResumeBtn").GetComponent<Button>().
            onClick.AddListener(()=>gameObject.SetActive(false));
        transform.Find("MainMenuBtn").
            GetComponent<Button>().onClick.AddListener(()=>SceneManager.LoadScene("MainMenu"));
        transform.Find("QuitBtn").GetComponent<Button>().onClick.AddListener(()=>Application.Quit());
        gameObject.SetActive(false);
        transform.Find("MusicSlider").GetComponent<Slider>().
            onValueChanged.AddListener((float value) =>
            {
                MusicClass.instance.GetComponent<AudioSource>().volume = value;
            });
    }
}
