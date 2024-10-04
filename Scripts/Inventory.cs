using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject slotPrefab;
    public Transform slotContainer;
    public int slotCount;

    private List<InventorySlot> slots = new List<InventorySlot> ();

    void Awake()
    {
        CreateSlots();
    }

    void CreateSlots(){
        for (int i = 0; i < slotCount; i++){
            GameObject newSlot = Instantiate(slotPrefab, slotContainer);
            InventorySlot slotCompnent = newSlot.GetComponent<InventorySlot>();
            slots.Add(slotCompnent);
        }
    }
    
    public bool AddItemToEmptySlot(Item newItem){
        foreach (var slot in slots){
            if (slot.IsEmpty()){
                slot.AddItem(newItem);
                return true;
            }

        }
        Debug.Log("Boş slot yok!");
        return false;
    }

}
