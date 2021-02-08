﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryCardScript : MonoBehaviour
{

    [SerializeField] private GameObject cardBack;
    public void OnMouseDown()
    {
        if (cardBack.activeSelf && controller.canReveal)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }

    [SerializeField] private SceneController controller;
    private int _id;
    public int id
    {
        get 
        { 
            return _id;
        }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }
}
