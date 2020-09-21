using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;
using Mirror;

//Server manager
public class ServerManager : NetworkBehaviour
{
    int enemyDeckCardsnumber;
    int enemyhandCardsNumber;
    public CardDisplay cardPrefab;
    public Deck testDeck; //na potrzeby testow

    [SerializeField]
    private Deck myDeck;

    [SerializeField]
    private Deck enemyDeck;

    
    public Deck myTestDeck;
    public Deck enemyTestDeck;

    //public Deck myDeck;
    //public Deck enemyDeck;
    //public Hand myHand;
    //public Hand enemyHand;
    //public Player myPlayer;
    //public Player enemyPlayer;
    //int fatigue = 0;
    //public Wallet myWallet;
    //public Wallet enemyWallet;
    //public PlaygroundArena myPlayground;
    //public PlaygroundArena enemyPlayground;

    public override void OnStartServer()
    {
        SpawnCard();
        InitDecks();
    }

    private void InitDecks()
    {
        Debug.Log("hello from ServerManager");
        myDeck.initDeck(myTestDeck.cards, cardPrefab);
    }

    public void SpawnCard()
    {
        Debug.Log("hi from cmd");
        cardPrefab.Init(testDeck.cards[2]);
        CardDisplay card = Instantiate(cardPrefab, myDeck.transform);
        NetworkServer.Spawn(card.gameObject);
    
    }

    





    //private void shuffleDeck(Deck deck)
    //{
    //}

    //private void handleFullHandDraw()
    //{
    //    Debug.Log("Full hand!");
    //}

    //private void handleEmptyDeck()
    //{
    //    Debug.Log("No cards in deck!");
    //}

    //public void drawCards(int number)
    //{

    //    for(int i=0; i<number; i++)
    //    {
    //        int currentDeckSize = myDeck.displayCards.Count;
    //        Debug.Log("Decksize = " + currentDeckSize);


    //        if(currentDeckSize>0)
    //        {     
    //                if(!myHand.full)
    //                {
    //                    myHand.drawCard(myDeck.getTop());
    //                }
    //                else
    //                {
    //                    handleFullHandDraw();
    //                }       
    //        }
    //        else
    //        {
    //            handleEmptyDeck();
    //        }
    //    }

    //    Debug.Log("From Menager, handSize is " + myHand.handCards.Count);
    //}

    //public void drawSingleCard()
    //{

    //}

    //private void drawDeckIDs(List<Card> cards)
    //{
    //    foreach(Card card in cards)
    //    {
    //        Debug.Log("Cards with testing deck id = " + card.GetInstanceID());
    //    }
    //}

    //public bool CanThrowCardOnBoard(CardDisplay card)
    //{
    //    if (myPlayground.full)
    //    {
    //        Debug.Log("Playground is full");
    //        return false;
    //    }
    //    else if (myWallet.coins < card.card.cost)
    //    {
    //        Debug.Log("No coins needed!");
    //        return false;
    //    }

    //        return true;
    //}



}
