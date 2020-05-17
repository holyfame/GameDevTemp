using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class UIButton : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    [SerializeField] Card card;
    public Color highlightColor = Color.cyan;

    public void OnMouseOver()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = highlightColor;
        }
    }

    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = Color.white;
        }
    }

    public void OnMouseDown()
    {
        transform.localScale *= 1.1f;
    }

    public void OnMouseUp()
    {
        transform.localScale /= 1.1f;

        sceneController.Pass(card.church, card.army, card.science, card.rich);
    }
}
