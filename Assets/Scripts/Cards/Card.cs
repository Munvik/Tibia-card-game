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

    //public void CreateCardInstance(Transform parent)
    //{
    //    GameObject deck = GameObject.Find("MyDeck");

    //    prefab.card = Instantiate(this);
    //    owner = Instantiate(prefab.gameObject, parent);
        
    //}

    //public void CreateCardInstance()
    //{
    //    GameObject deck = GameObject.Find("MyDeck");

    //    owner = Instantiate(prefab.gameObject, deck.transform);
    //    prefab.card = this;
    //}

    public Card(Card card)
    {
        artwork = card.artwork;
        title = card.title;
        description = card.description;
        cost = card.cost;
        hp = card.hp;
        minDmg = card.minDmg;
        maxDmg = card.maxDmg;       
        exp = card.exp;
}

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    

    private void OnValidate()
    {
        string path = AssetDatabase.GetAssetPath(this);
        id = AssetDatabase.AssetPathToGUID(path);
    }

    public CardDisplay CreateCardInstance(Transform parent)
    {
        var instance = Instantiate(prefab,parent);
        instance.card = Instantiate(this);

        return instance;
    }

}
