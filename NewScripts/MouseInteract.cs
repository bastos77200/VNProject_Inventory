using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteract : MonoBehaviour {
    public Inventory inventory;


    // Use this for initialization
    void Start () {
        HighLight highlight = GetComponent<HighLight>();
        if (highlight != null)
        {
            highlight.StartHighlight();
        }
    }
	
	// Update is called once per frame
	void Update () {
        //inventory.AddItem();
      
    }

    private void OnMouseDown()
    {
     
        Debug.Log("collide");

        inventory.AddItem(gameObject);
    
        
    }
}
