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

    public void Init(Card card_)
    {
        card = card_;

        title.text = card.title;
        artworkImage.sprite = card.artwork;
        cost.text = card.cost.ToString();
        description.text = card.description;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setRectTransform(RectTransform rectTransform)
    {
        RectTransform ownerRect = GetComponent<RectTransform>();
        //owner.transform.localScale = new Vector3(rectTransform.localScale.x, rectTransform.localScale.y, rectTransform.localScale.z);
        ownerRect.position = rectTransform.position;
        ownerRect.localScale = rectTransform.localScale;
        ownerRect.localRotation = rectTransform.localRotation;

    }

    public void turnBack()
    {
        GameObject rawBackground = transform.Find("raw background").gameObject;
        bool setup = rawBackground.activeSelf;
        rawBackground.SetActive(!setup);
    }

    public void setPosition(Vector3 position)
    {
        transform.localPosition = position;
    }

    public void changeParent(Transform parent) //change hierarchy position
    {
        transform.parent = parent;
    }

    public void changeCost(int cost)
    {
        card.cost = cost;
        Init(card);
    }
}
