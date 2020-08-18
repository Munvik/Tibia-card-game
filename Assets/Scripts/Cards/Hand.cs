using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    // Start is called before the first frame update
    public List<CardDisplay> handCards;
    public Deck deck;
    public int maxHandSize = 12;
    public bool full = false;
    public RectTransform template;

    void Start()
    {
        handCards = new List<CardDisplay>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void init()
    {
    }

    public void drawCard(CardDisplay card)
    {
        Debug.Log("Drawing card with id = " + card.GetInstanceID());
        deck.displayCards.Remove(card);
        putInto(card);
             
    }

    public void putInto(CardDisplay card)
    {


        card.changeParent(transform);
        handCards.Add(card);

        Debug.Log("handcards.size = " + handCards.Count);
        card.setRectTransform(template);
        card.turnBack();
    }


}
