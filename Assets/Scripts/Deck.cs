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
        //narazie sie pojawia na stosie kart
        card.turnBack();
        
        cards.Add(card);

    }


    public void initDeck() //zainicjowanie stosu talii na pcozatku gry
    {
        int 
        foreach(Card card in cards)
        {
            card.CreateCardInstance();
            card.setRectTransform(templateCard);
            card.owner
            card.turnBack();
        }
    }


}
