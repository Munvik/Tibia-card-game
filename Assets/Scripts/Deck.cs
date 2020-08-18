using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> cards;

    public RectTransform templateCard;
    public Vector3 stackOffset = new Vector3(100f, 100f, 20f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Deck(List<Card> deck)
    {
        cards = deck;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void shuffleInto(Card card)
    {
        cards.Add(Instantiate(card));

        Card existingCard = getTop();
        existingCard.CreateCardInstance();
        existingCard.setRectTransform(templateCard);
        existingCard.turnBack();

        float x = templateCard.position.x + cards.Count * stackOffset.x;
        float y = templateCard.position.y + cards.Count * stackOffset.y;
        float z = templateCard.position.z + cards.Count * stackOffset.z;
        Vector3 newPosition = new Vector3(x, y, z);
        existingCard.setPosition(newPosition);

    }


    public void initDeck(List<Card> cards_) //zainicjowanie stosu talii na pcozatku gry
    {
        
        foreach(Card card in cards_)
        {
            shuffleInto(card);           
        }
    }

    public Card getTop()
    {
        return cards[cards.Count - 1];
    }


}
