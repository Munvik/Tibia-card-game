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

    [SerializeField] string id;
    public string ID { get { return id; } }

    public CardDisplay prefab;
    
    public GameObject owner;

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

    


    public CardDisplay CreateCardInstance(Transform parent)
    {
        var instance = Instantiate(prefab,parent);
        
        instance.card = Instantiate(this);

        return instance;
    }

    public CardDisplay CreateCardInstance()
    {
        var instance = Instantiate(prefab);

        instance.card = Instantiate(this);

        return instance;
    }

}
