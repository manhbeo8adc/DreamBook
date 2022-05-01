using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuBoard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<RectTransform>().localPosition = Vector3.zero;

        transform.Find("PlayBtn").
            GetComponent<Button>().onClick.AddListener(() => SceneManager.LoadScene("MainScene"));

        transform.Find("SettingBtn").
            GetComponent<Button>().onClick.AddListener(() =>
            {
                SettingBoard.instance.gameObject.SetActive(true);
                gameObject.SetActive(false);
            });

        transform.Find("QuitBtn").
            GetComponent<Button>().onClick.AddListener(() => Application.Quit());
    }
}
