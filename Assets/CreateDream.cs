using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateDream : MonoBehaviour
{
    public void ChangeColor()
    {
        GameAssets.i.predictionImage.color = Color.red;
    }
    public void SetUserInputString(string s)
    {
        GameAssets.i.userInputString = s;
        Debug.Log(GameAssets.i.userInputString);
    }
}
