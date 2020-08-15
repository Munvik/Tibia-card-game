using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New class", menuName = "Card")]
public class Card : ScriptableObject
{
    
    public Sprite artwork;
    public string title;
    public string description;
    public int cost;
    public int hp;
    public int minDmg;
    public int maxDmg;
    public int exp;

    public CardDisplay prefab;

    GameObject owner;

    public void CreateCardInstance()
    {
        GameObject deck = GameObject.Find("MyStackofCards");
        prefab.card = this;
        owner = Instantiate(prefab.gameObject, deck.transform);
    }

    public void turnBack()
    {
        owner.transform.Find("raw background").gameObject.SetActive(true);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setRectTransform(RectTransform rectTransform)
    {
        RectTransform ownerRect = owner.GetComponent<RectTransform>();
        //owner.transform.localScale = new Vector3(rectTransform.localScale.x, rectTransform.localScale.y, rectTransform.localScale.z);
        ownerRect.position = rectTransform.position;
        ownerRect.localScale = rectTransform.localScale;
    }

    public void setPosition(Vector3 position)
    {
        owner.transform.position = position;
    }

}
