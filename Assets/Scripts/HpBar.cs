using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBar : MonoBehaviour
{
    public RectTransform greenBar;
    public int maxhp { get; set; } //max hp
    int currentHp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void init(int hp)
    {
        maxhp = hp;
        currentHp = hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void substract(int hp)
    {
        currentHp -= hp;

        if (currentHp < 0)
            currentHp = 0;

        float width = (float)currentHp / (float)maxhp * 100;
        greenBar.sizeDelta = new Vector2(width, greenBar.sizeDelta.y);

    }
}
