using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaygroundArena : MonoBehaviour
{
    public List<CardDisplay> cards;
    public RectTransform template;

    public int maxCards = 9;
    public bool full = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PutIn(CardDisplay card)
    {
        card.setRectTransform(template);
        cards.Add(card);
        
        if(cards.Count == maxCards)
        {
            full = true;
        }
    }
}
