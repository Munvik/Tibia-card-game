using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Card> handCards;
    public Deck deck;
    public int maxHandSize = 12;
    public bool full = false;
    public RectTransform template;

    void Start()
    {
        handCards = new List<Card>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void init()
    {
    }

    public void drawCard(Card card)
    {
        Debug.Log("Drawing card with id = " + card.owner.GetInstanceID());
        putInto(card);
        deck.cards.Remove(card);     
    }

    public void putInto(Card card)
    {
        
       
        card.changeParent(transform.gameObject);
        handCards.Add(card);

        Debug.Log("handcards.size = " + handCards.Count);
        card.setRectTransform(template);
        card.turnBack();
    }


}
