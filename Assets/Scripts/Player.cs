using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class Player : NetworkBehaviour
{
    public PlayerClass vocation;
    public HpBar hpbar;
    int hp;
    public Image avatarArtwork;



    // Start is called before the first frame update
    public override void OnStartClient()
    {
        base.OnStartClient();
    
    
        
        avatarArtwork.sprite = vocation.avatarArtwork;
        hpbar.init(vocation.hp);
        //hp = vocation.hp;
        //Menager.getInstance().myWallet.Init(vocation.tibiaCoinsOnStart);

        //Debug.Log(Menager.instance.GetInstanceID());
    }

    [Server]
    public override void OnStartServer()
    {
        Debug.Log("Siema z player");
    }


    public void TakeDamage(int damage)
    {
        hp -= damage;
        hpbar.substract(damage);
    }
}
