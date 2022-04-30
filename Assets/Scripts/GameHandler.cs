using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameHandler : MonoBehaviour
{
    private void Awake()
    {
        int index = Random.Range(0, GameAssets.i.items.Count);
        GameAssets.i.item = GameAssets.i.items[index];
        GameAssets.i.itemPicture.GetComponent<SpriteRenderer>().sprite = GameAssets.i.item.image;
        RandomWordsToGuess();
    }

    private void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            GameAssets.i.wordsDisplay.transform.
                GetChild(i).GetChild(0).GetComponent<TextMeshPro>().text = GameAssets.i.wordsToGuess[i];
        }
    }

    public bool Guess(string word)
    {
        if (GameAssets.i.wordsToGuess.Contains(word)){
            return true;
        }
        else
        {
            return false;
        }
    }

    public void RandomWordsToGuess()
    {
        for (int i = 0; i < 3; i++)
        {
            int index = Random.Range(0, GameAssets.i.meaningWords.Count);
            while (GameAssets.i.wordsToGuess.Contains(GameAssets.i.meaningWords[index]))
            {
                index = Random.Range(0, GameAssets.i.meaningWords.Count);
            }
            GameAssets.i.wordsToGuess[i] = GameAssets.i.meaningWords[index];
        }
    }
}
