using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class Menager : MonoBehaviour
{

    public static Menager instance = null;
    int enemyDeckCardsnumber;
    int enemyhandCardsNumber;

    public Deck testDeck; //na potrzeby testow

    public Deck myDeck;
    public Hand myHand;
    public Player myplayer;
    public Player enemyPlayer;
    int fatigue = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Menager(Deck ownDeck, int enemyDeckSize, int enemyHandSize)
    {
        enemyDeckCardsnumber = enemyDeckSize;
        enemyhandCardsNumber = enemyHandSize;



    }

    private void Awake()
    {

        if (instance)
        {
            Debug.Log("Proba utworzenia drugiej instancji Menadzera !");
        }
   
        instance = this;

        myDeck.initDeck(testDeck.cards);

        drawCards(4);
        myHand.handCards[1].changeCost(45);
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
        Debug.Log("Full hand!");
    }

    private void handleEmptyDeck()
    {
        Debug.Log("No cards in deck!");
    }

    public void drawCards(int number)
    {

        for(int i=0; i<number; i++)
        {
            int currentDeckSize = myDeck.displayCards.Count;
            Debug.Log("Decksize = " + currentDeckSize);


            if(currentDeckSize>0)
            {     
                    if(!myHand.full)
                    {
                        myHand.drawCard(myDeck.getTop());
                    }
                    else
                    {
                        handleFullHandDraw();
                    }       
            }
            else
            {
                handleEmptyDeck();
            }
        }

        Debug.Log("From Menager, handSize is " + myHand.handCards.Count);
    }

    public void drawSingleCard()
    {

    }

    private void drawDeckIDs(List<Card> cards)
    {
        foreach(Card card in cards)
        {
            Debug.Log("Cards with testing deck id = " + card.GetInstanceID());
        }
    }


}
