using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputString : MonoBehaviour
{
    public static GameObject isSelected;
    TextMeshPro gt;

    private void Awake()
    {
        gt = transform.GetChild(0).GetComponent<TextMeshPro>();
    }

    void Update()
    {
        if (isSelected == gameObject)
        {
            foreach(char c in Input.inputString)
            {
                if (c == '\b') // has backspace/delete been pressed?
                {
                    if (gt.text.Length != 0)
                    {
                        gt.text = gt.text.Substring(0, gt.text.Length - 1);
                    }
                }
                else if ((c == '\n') || (c == '\r')) // enter/return
                {
                    isSelected = null;
                }
                else
                {
                    gt.text += c;
                }

            }
        }
        else
        {
            gameObject.transform.GetChild(0).GetComponent<TextMeshPro>().color = GameAssets.i.defaultColor;
        }
    }
}
