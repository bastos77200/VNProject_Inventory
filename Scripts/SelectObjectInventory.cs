using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObjectInventory : MonoBehaviour {
    //Déclaration de la variable de type Inventaire
    Inventory Inventory_script;


    private void Start()
    {
        //recherche GameObject du nom Inventory et son composant Inventory
        Inventory_script = GameObject.Find("Inventory").GetComponent<Inventory>();
    }
    public void Selection()
    {

        // Numero de slot

        int numeroSlot = transform.parent.GetSiblingIndex();

        //Décremente de 1 le stock du slot
        Inventory_script.slot[numeroSlot] -= 1;
        Inventory_script.UpdateRessource(numeroSlot, Inventory_script.slot[numeroSlot].ToString());

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
