using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FitColliderToText : MonoBehaviour
{
    void Update()
    {
        int count = transform.GetChild(0).GetComponent<TextMeshPro>().text.Length;
        if(GetComponent<BoxCollider2D>() != null)
        {
            GetComponent<BoxCollider2D>().size = new Vector2(count * 0.3f, 0.5f);
        }
    }
}
