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
        //GameObject[] AllGo;
        //AllGo = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[];

        //foreach(GameObject GO in AllGo)
        //{
        //    Debug.Log("Object name = " +GO.name);
        //}


        //Debug.Log("Hello from [Server] Manager::OnStartServer()");

        //myDeck = GameObject.Find("MyDeck").GetComponent<Deck>();
        //enemyDeck = GameObject.Find("EnemyDeck").GetComponent<Deck>();
        //myHand = GameObject.Find("MyHand").GetComponent<Hand>();
        //enemyHand = GameObject.Find("EnemyHand").GetComponent<Hand>();
        //myPlayer = GameObject.Find("MyPlayer").GetComponent<Player>();
        //enemyPlayer = GameObject.Find("EnemyPlayer").GetComponent<Player>();
        //myWallet = GameObject.Find("MyWallet").GetComponent<Wallet>();
        //enemyWallet = GameObject.Find("EnemyWallet").GetComponent<Wallet>();
        //myPlayground = GameObject.Find("MyPlagroundArena").GetComponent<PlaygroundArena>();
        //enemyPlayground = GameObject.Find("EnemyPlagroundArena").GetComponent<PlaygroundArena>();


        Debug.Log("Hello spawn here");

        CmdSpawnCard();
    }

    [Command]
    public void CmdSpawnCard()
    {
        cardPrefab.Init(testDeck.cards[3]);
        CardDisplay card = Instantiate(cardPrefab);
        NetworkServer.Spawn(cardPrefab.gameObject);
    }



    //[Server]
    //public override void OnStartServer()
    //{
    //    //List<Card> mycards = new List<Card>();
    //    //List<Card> enemycards = new List<Card>();

    //    //for (int i = 0; i < 5; i++)
    //    //{
    //    //    Card card = testDeck.cards[Random.Range(0, testDeck.cards.Count)];
    //    //    mycards.Add(card);

    //    //    Card card2 = testDeck.cards[Random.Range(0, testDeck.cards.Count)];
    //    //    enemycards.Add(card2);
    //    //}

    //    //myDeck.initDeck(mycards);
    //    //enemyDeck.initDeck(enemycards);
    //    Debug.Log("Hello from server");
    //}

    

    //public Menager(Deck ownDeck, int enemyDeckSize, int enemyHandSize)
    //{
    //    enemyDeckCardsnumber = enemyDeckSize;
    //    enemyhandCardsNumber = enemyHandSize;

    //}

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
