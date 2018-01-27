﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour {

    private SpriteRenderer sr;
    public Sprite[] sprites;

    int currentSprite = 0;

    public void StartCountdown()
    {
        InvokeRepeating("NextNumber", 1, 1);
        sr = GetComponent<SpriteRenderer>();
    }

    void NextNumber()
    {
        if (currentSprite == sprites.Length)
        {
            CancelInvoke();
            FindObjectOfType<RoundManager>().StartNextRound();
            sr.sprite = null;   
            return;
        }

        sr.sprite = sprites[currentSprite++];
    }

}