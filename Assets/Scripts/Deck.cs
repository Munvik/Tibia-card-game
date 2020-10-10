
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Deck : NetworkBehaviour
{
    public List<Card> cards;
    public List<CardDisplay> displayCards;

    public RectTransform templateCard;
    public Vector3 stackOffset = new Vector3(0f, 0f, 0f);

    public ServerManager serverManager;

    public GameObject prefab;

    public void Init(ServerManager serverManager)
    {
        this.serverManager = serverManager;
    }



    public void shuffleInto(CardDisplay card)
    {
        displayCards.Add(card);
        Debug.Log("getTop() = " + getTop().GetInstanceID());
        
        CardDisplay newestCard = getTop();     
        newestCard.setRectTransform(templateCard);
        newestCard.setReversed(true);
        serverManager.RpcChangeParent(newestCard.gameObject);

        float x = templateCard.position.x + displayCards.Count * stackOffset.x;
        float y = templateCard.position.y + displayCards.Count * stackOffset.y;
        float z = templateCard.position.z + displayCards.Count * stackOffset.z;
        Vector3 newPosition = new Vector3(x, y, z);
        newestCard.setPosition(newPosition);
    }

    public void InitDeck(List<Card> cards_) //zainicjowanie stosu talii na pcozatku gry
    {
        Debug.Log("Deck::InitDeck()");
        
        foreach(Card card in cards_)
        {           
            GameObject cardToSpawn = Instantiate(prefab);
            CardDisplay cardDisplay = cardToSpawn.GetComponent<CardDisplay>();
            cardDisplay.Init(card);
            NetworkServer.Spawn(cardToSpawn, connectionToClient);
            shuffleInto(cardDisplay);           
        }
    }

    public CardDisplay getTop()
    {
        return displayCards[displayCards.Count - 1];
    }

    


}
