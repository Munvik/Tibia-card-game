using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//THIS IS CARD LOGIC SCRIPT

public class CardDisplay : Draggable
{
    public Card card;

    public Text title;
    public Sprite artworkImage;
    public Text cost;
    public Text description;

    // Start is called before the first frame update
    void Start()
    {  
        
    }

    public void Init(Card card_)
    {
        card = card_;

        title.text = card.title;
        artworkImage = card.artwork;
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
        Debug.Log(rectTransform.localScale);
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

    public void setReversed(bool reversed)
    {
        GameObject rawBackground = transform.Find("raw background").gameObject;
        rawBackground.SetActive(reversed);
    }

    public void setPosition(Vector3 position)
    {
        transform.localPosition = position;
    }

    public void changeParent(Transform parent) //change hierarchy position
    {
        //transform.parent = parent;
        transform.SetParent(parent);
    }

    public void changeCost(int cost)
    {
        card.cost = cost;
        Init(card);
    }

    //public void setDraggableEnable(bool enable)
    //{
    //    Draggable draggable = GetComponent<Draggable>();

    //    if (draggable)
    //    {
    //        draggable.enabled = enable;
    //    }
    //    else
    //        Debug.Log("Cannot find draggable component");
    //}
    override public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDragableee");
        startPos = gameObject.transform.localPosition;
    }


    override public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;


    }

    override public void OnEndDrag(PointerEventData eventData)
    {
        Hand hand = GameObject.Find("MyHand").GetComponent<Hand>();

        if (!hand)
        {
            Debug.Log("Cannot find Myhand component");
        }

        GameObject myArena = GameObject.Find("My Playground Arena");

        if(MenagerPhysics.MouseIsOn(myArena))
        {
            Hand myhand = GameObject.Find("MyHand").GetComponent<Hand>();
        }


        gameObject.transform.localPosition = startPos;
    }


}
