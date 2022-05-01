using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public delegate void ButtonClick(string name);
    public event ButtonClick OnButtonClick;
    private void OnMouseDown()
    {
        OnButtonClick += FlipPage.i.ButtonOnClick;
        OnButtonClick(gameObject.name);
    }
    private void OnMouseUp()
    {
        OnButtonClick -= FlipPage.i.ButtonOnClick;
    }
}
