using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public static class MenagerPhysics 
{

    public static bool MouseIsOn(GameObject gameobject)
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (gameobject == hit.collider.gameObject)
            {
                return true;
            }
        }

        return false;
    }

}
