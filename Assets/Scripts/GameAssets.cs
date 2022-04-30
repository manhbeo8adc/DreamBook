using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameAssets : MonoBehaviour
{
    public static GameAssets i;
    public GameObject itemPicture;
    public Item item;
    public List<string> wordsToGuess = new List<string>(3);
    public List<string> meaningWords = new List<string>();
    public List<Item> items = new List<Item>();
    public GameObject wordsDisplay;
    void Awake()
    {
        i = GetComponent<GameAssets>();  
    }
}
