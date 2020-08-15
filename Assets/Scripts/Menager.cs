using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class Menager : MonoBehaviour
{

    public static Menager instance = null;
    int enemyDeckCardsnumber;
    int enemyhandCardsNumber;

    public Card testCard;

    public Deck myDeck;
    int fatigue = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Menager(Deck ownDeck, int enemyDeckSize, int enemyHandSize)
    {
        enemyDeckCardsnumber = enemyDeckSize;
        enemyhandCardsNumber = enemyHandSize;


        myDeck.initDeck();

    }

    private void Awake()
    {

        if (instance)
        {

            Debug.Log("Proba utworzenia drugiej instancji Menadzera !");
        }

        instance = this;
        myDeck.initDeck();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void shuffleDeck(Deck deck)
    {
    }

    private void handleFullHandDraw()
    {
        //TODO
    }

    public void drawCards(int number)
    {

        for(int i=0; i<number; i++)
        {
            int currentDeckSize = myDeck.cards.Count;


            if(currentDeckSize>0)
            {     
                GameObject myHand = GameObject.Find("MyHand");

                HandHandler handHndl = myHand.GetComponent<HandHandler>();

                if(handHndl!=null)
                {
                    if(!handHndl.full)
                    {
                        handHndl.drawCard(myDeck.cards[currentDeckSize - 1]);
                    }
                    else
                    {
                        handleFullHandDraw();
                    }
                }
                else
                {
                    Debug.Log("Cannot find hand handler component in " + transform.name);
                }

                
            }
        }
    }

    public void drawSingleCard()
    {

    }


}
