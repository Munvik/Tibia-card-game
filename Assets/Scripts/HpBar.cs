using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpBar : MonoBehaviour
{
    public RectTransform greenBar;
    public int maxhp { get; set; } //max hp
    int hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void init(int hp)
    {
        maxhp = hp;
        this.hp = hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void substract(int hp)
    {

    }
}
