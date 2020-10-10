using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;
using Mirror;

//Server manager
public class ServerManager : NetworkBehaviour
{
    private int enemyDeckCardsnumber;
    int enemyhandCardsNumber;

    public CardDisplay cardPrefab;
    public Deck testDeck; //na potrzeby testow

    [SerializeField]
    private Deck myDeck;

    [SerializeField]
    private Deck enemyDeck;


    [SerializeField]
    private Deck myTestDeck;
    [SerializeField]
    private Deck enemyTestDeck;

    [SerializeField]
    private Hand myHand;
    [SerializeField]
    private Hand enemyHand;
    [SerializeField]
    private Player myPlayer;
    [SerializeField]
    private Player enemyPlayer;
    [SerializeField]
    private Wallet myWallet;
    [SerializeField]
    private Wallet enemyWallet;
    [SerializeField]
    private PlaygroundArena myPlayground;
    [SerializeField]
    private PlaygroundArena enemyPlayground;
    [SerializeField]



    public override void OnStartServer()
    {

    }

    public override void OnStartClient()
    {
        base.OnStartClient();
        Debug.Log("OnStartClient()");
    }


    private void InitDecks()
    {
        Debug.Log("hello from ServerManager::InitDecks()");
        myDeck.InitDeck(myTestDeck.cards);
    }

    [ClientRpc]
    public void RpcChangeParent(GameObject card)
    {
        Debug.Log("rpc");

        if(hasAuthority)
            card.transform.SetParent(myDeck.transform);
        else
        {
            card.transform.SetParent(enemyDeck.transform);
        }      
    }


    public void DealCards()
    {
        Debug.Log("ServerManager::DealCards()");
        InitDecks();
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
