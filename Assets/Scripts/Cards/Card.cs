using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

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

    [SerializeField] string id;
    public string ID { get { return id; } }

    public CardDisplay prefab;
    
    public GameObject owner;

    public void CreateCardInstance(Transform parent)
    {
        GameObject deck = GameObject.Find("MyDeck");

        prefab.card = Instantiate(this);
        owner = Instantiate(prefab.gameObject, parent);
        
    }

    public void CreateCardInstance()
    {
        GameObject deck = GameObject.Find("MyDeck");

        owner = Instantiate(prefab.gameObject, deck.transform);
        prefab.card = this;
    }

    public void turnBack()
    {
        GameObject rawBackground = owner.transform.Find("raw background").gameObject;
        bool setup = rawBackground.activeSelf;
        rawBackground.SetActive(!setup);
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
        ownerRect.localRotation = rectTransform.localRotation;

    }

    public void setPosition(Vector3 position)
    {
        owner.transform.localPosition = position;
    }

    public void changeParent(GameObject parent) //change hierarchy position
    {
        owner.transform.parent = parent.transform;
    }

    private void OnValidate()
    {
        string path = AssetDatabase.GetAssetPath(this);
        id = AssetDatabase.AssetPathToGUID(path);
    }

    //public Card CreateCardInstance()
    //{
    //    GameObject deck = GameObject.Find("MyDeck");

    //    owner = Instantiate(prefab.gameObject, deck.transform);
    //    prefab.card = this;
    //}

}
