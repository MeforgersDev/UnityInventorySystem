using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image itemIcon;
    private Item currentItem;

    public void AddItem (Item newItem){
        currentItem = newItem;
        itemIcon.sprite = newItem.itemIcon;
        itemIcon.enabled = true;
    }
    public bool IsEmpty(){
        return currentItem == null;
    }

    public void ClearSlot(){
        currentItem = null;
        itemIcon.enabled = false;
    }
}
