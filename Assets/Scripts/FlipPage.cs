using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlipPage : MonoBehaviour
{
    public static FlipPage i;
    public static int currentPageIndex = -1;
    private void Awake()
    {
        i = GetComponent<FlipPage>();
    }
    public void ButtonOnClick(GameObject gameObject)
    {
        switch (gameObject.name)
        {
            default:
            case "TurnLeftButton":
                {
                    currentPageIndex -= 1;
                    break;
                }
            case "TurnRightButton":
                {
                    currentPageIndex += 1;
                    break;
                }
            case "Word":
                {
                    gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().color = Color.green;
                    gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().text = "";
                    InputString.isSelected = gameObject;
                    break;
                }
            case "StartButton":
                {

                    GameAssets.i.flipButtons.SetActive(true);
                    gameObject.SetActive(false);
                    break;
                }
        }
        if (currentPageIndex < 0) currentPageIndex = 0;
        if (currentPageIndex >= GameAssets.i.Book.childCount)
        {
            AddPage();
            GameHandler.instance.AddPageContent(currentPageIndex % 2 == 0);
        }
        foreach (Transform t in GameAssets.i.Book)
        {
            t.gameObject.SetActive(false);
        }
        GameAssets.i.Book.GetChild(currentPageIndex).gameObject.SetActive(true);
    }

    private static void AddPage()
    {
        GameObject page = Instantiate(GameAssets.i.page);
        page.name = $"Pages_{currentPageIndex}";
        page.transform.SetParent(GameAssets.i.Book);
        GameAssets.i.wordsDisplay.Add(page.transform.GetChild(1));
        GameAssets.i.itemPicture.Add(page.transform.GetChild(0));
    }
}
