using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text title;
    public Image artworkImage;
    public Text cost;
    public Text description;

    // Start is called before the first frame update
    void Start()
    {
        title.text = card.title;
        artworkImage.sprite = card.artwork;
        cost.text = card.cost.ToString();
        description.text = card.description;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
