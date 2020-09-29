
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Deck : NetworkBehaviour
{
    public List<Card> cards;
    public List<CardDisplay> displayCards;

    public RectTransform templateCard;
    public Vector3 stackOffset = new Vector3(100f, 100f, 20f);



    public void shuffleInto(CardDisplay card)
    {
        displayCards.Add(card);
        Debug.Log("From shuffleinto and the newest card has id = " + getTop().GetInstanceID());
        CardDisplay newestCard = getTop();
        
        newestCard.setRectTransform(templateCard);
        newestCard.setReversed(true);
        //newestCard.changeParent(transform);

        float x = templateCard.position.x + displayCards.Count * stackOffset.x;
        float y = templateCard.position.y + displayCards.Count * stackOffset.y;
        float z = templateCard.position.z + displayCards.Count * stackOffset.z;
        Vector3 newPosition = new Vector3(x, y, z);
        newestCard.setPosition(newPosition);

    }

    public void initDeck(List<Card> cards_, CardDisplay cardPrefab) //zainicjowanie stosu talii na pcozatku gry
    {
        
        foreach(Card card in cards_)
        {

            
            CardDisplay cardToSpawn = Instantiate(cardPrefab, transform);
            cardToSpawn.Init(card);
            NetworkServer.Spawn(cardToSpawn.gameObject);
            cardToSpawn.setDraggableEnable(false);
            shuffleInto(cardToSpawn);           
        }
    }

    public CardDisplay getTop()
    {
        return displayCards[displayCards.Count - 1];
    }


}
