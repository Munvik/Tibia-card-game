
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Deck : NetworkBehaviour
{
    public List<Card> cards;
    public List<CardDisplay> displayCards;

    public RectTransform templateCard;
    public Vector3 stackOffset = new Vector3(0f, 0f, 0f);

    private ServerManager serverManager;

    public CardDisplay prefab;

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
        Debug.Log("newestCard.gameobject = " + newestCard.gameObject.GetInstanceID());
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
            CardDisplay cardToSpawn = Instantiate(prefab);
            cardToSpawn.Init(card);
            NetworkServer.Spawn(cardToSpawn.gameObject, connectionToClient);
            Debug.Log("Po spawnie id = " + cardToSpawn.GetInstanceID());
            shuffleInto(cardToSpawn);           
        }
    }

    public CardDisplay getTop()
    {
        return displayCards[displayCards.Count - 1];
    }

    


}
