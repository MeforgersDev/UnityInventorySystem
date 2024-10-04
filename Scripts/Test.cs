using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public Inventory inventory;
    public Item[] testItems;

    void Start (){
        foreach (var item in testItems){
            inventory.AddItemToEmptySlot(item);
        }
    }
}
