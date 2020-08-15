using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardShow : MonoBehaviour
{
    public int BiggerCardDisplayTimeMs;
    Ray ray;
    RaycastHit2D hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hit = Physics2D.Raycast(Camera.main.transform.position, Input.mousePosition);



        if(hit != null && hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }
}
