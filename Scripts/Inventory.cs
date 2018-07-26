using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    //activation du panel contenant les slots
    bool activation = false;
    //on recupere le GameObject PAnel
    GameObject Panel;
    //On déclare un tableau pour les slots
    public int[] slot;


    private void Start()
    {
        GetComponent<Canvas>().enabled = false;
        //Panel = 1er enfant GameObjectInventory
        Panel = transform.GetChild(0).gameObject;

        //Les enfants de mon panel
        slot = new int[Panel.transform.childCount];
    }
    void Update()
    {
        //Lorsque j'appuie sur I
        if(Input.GetKeyDown(KeyCode.I))
        {
            //alors j'affiche mon canvas
            activation = !activation;
            GetComponent<Canvas>().enabled = activation;
        }

        
    }

    public void UpdateRessource(int numeroSlot, string nbr)
    {
        //on recupere l'élément enfant txt du slot
        Panel.transform.GetChild(numeroSlot).GetChild(1).GetComponent<Text>().text = nbr;
    }
}
