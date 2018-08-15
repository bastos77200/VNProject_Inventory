using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    

    public GameObject[] inventory = new GameObject[10];

    public void AddItem(GameObject item)
    {
        bool itemAdded = false;
        
        //Recherche le premier slot de l'inventaire
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == null)
            {
                inventory[i] = item;
                Debug.Log(item.name + " il est ajouter");
                itemAdded = true;
                item.SetActive(false);
                
                
                break;
            }
            
        }

        //Inventaire complet
        if (!itemAdded)
        {
            Debug.Log("Inventaire compet - Item non ajouter");
            item.SetActive(true);
        }
        
    }
}
