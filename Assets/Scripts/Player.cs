﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public PlayerClass vocation;
    public HpBar hpbar;

    public Image avatarArtwork;
    // Start is called before the first frame update
    void Start()
    {
        avatarArtwork.sprite = vocation.avatarArtwork;
        hpbar.init(vocation.hp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
