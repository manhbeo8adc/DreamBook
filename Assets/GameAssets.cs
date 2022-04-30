using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameAssets : MonoBehaviour
{
    public static GameAssets i;
    public Image predictionImage;
    public string userInputString;
    public List<Image> itemImages = new List<Image> ();
    void Awake()
    {
        i = GetComponent<GameAssets>();
    }
}
