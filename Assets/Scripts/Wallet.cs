using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    public Text amountText;
    public int coins;
    // Start is called before the first frame update
    void Start()
    {
        amountText.text = coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(int coins)
    {
        this.coins = coins;
        amountText.text = coins.ToString();
    }

    public void SpendCoins(int coins)
    {
        this.coins -= coins;
        amountText.text = this.coins.ToString();
    }
}
