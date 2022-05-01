using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameHandler : MonoBehaviour
{
    public static GameHandler instance;
    private void Awake()
    {
        instance = this;
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && SceneManager.GetActiveScene().name == "MainScene")
        {
            SettingBoard.instance.gameObject.SetActive(true);
        }
    }

    public void AddPageContent(bool generateWord)
    {
        // Add image
        int index = Random.Range(0, GameAssets.i.items.Count);
        Item item = GameAssets.i.items[index];
        GameAssets.i.itemForPage.Add(item);
        GameAssets.i.itemPicture[FlipPage.currentPageIndex].GetComponent<SpriteRenderer>().sprite = item.image;

        //Add words
        if (generateWord)
        {
            RandomWordsToGuess();
            for (int i = 0; i < 3; i++)
            {
                Transform word = GameAssets.i.wordsDisplay[FlipPage.currentPageIndex].GetChild(i);
                Destroy(word.GetComponent<BoxCollider2D>());
                word.GetChild(0).GetComponent<TextMeshPro>().text = GameAssets.i.wordsToGuess[i];
            }
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
