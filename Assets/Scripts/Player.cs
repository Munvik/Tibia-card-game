using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public PlayerClass vocation;
    public HpBar hpbar;
    int hp;
    public Image avatarArtwork;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        Debug.Log("Siema");
        avatarArtwork.sprite = vocation.avatarArtwork;
        hpbar.init(vocation.hp);
        hp = vocation.hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
        hpbar.substract(damage);
    }
}
