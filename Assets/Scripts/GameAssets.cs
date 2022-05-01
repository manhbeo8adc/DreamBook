using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameAssets : MonoBehaviour
{
    public static GameAssets i;
    public List<Transform> itemPicture = new List<Transform>();
    public List<Item> itemForPage;
    public List<string> wordsToGuess = new List<string>(3);
    public List<string> meaningWords = new List<string>();
    public List<Item> items = new List<Item>();
    public List<Transform> wordsDisplay;
    public Transform Book;
    public GameObject page;

    void Awake()
    {
        i = GetComponent<GameAssets>();  
    }
}
