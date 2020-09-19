
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Deck : MonoBehaviour
{
    public List<Card> cards;
    public List<CardDisplay> displayCards;

    public RectTransform templateCard;
    public Vector3 stackOffset = new Vector3(100f, 100f, 20f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Deck(List<Card> deck)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void shuffleInto(CardDisplay card)
    {
        displayCards.Add(card);
        Debug.Log("From shuffleinto and the newest card has id = " + getTop().GetInstanceID());
        CardDisplay newestCard = getTop();

        newestCard.setRectTransform(templateCard);
        newestCard.setReversed(true);

        float x = templateCard.position.x + displayCards.Count * stackOffset.x;
        float y = templateCard.position.y + displayCards.Count * stackOffset.y;
        float z = templateCard.position.z + displayCards.Count * stackOffset.z;
        Vector3 newPosition = new Vector3(x, y, z);
        newestCard.setPosition(newPosition);

    }

    public void initDeck(List<Card> cards_) //zainicjowanie stosu talii na pcozatku gry
    {
        
        foreach(Card card in cards_)
        {
            var newest = card.CreateCardInstance(transform);
            newest.setDraggableEnable(false);
            newest.Init(newest.card);
            shuffleInto(newest);           
        }
    }

    public CardDisplay getTop()
    {
        return displayCards[displayCards.Count - 1];
    }


}
