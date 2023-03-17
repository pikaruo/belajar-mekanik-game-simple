using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemInventoryInventoryUI : MonoBehaviour
{

    [Header("System Inventory Inventory UI Object")]
    [SerializeField] private Transform itemsParent;

    [Header("System Inventory Inventory UI Script")]
    private SystemInventoryInventory inventory;
    private SystemInventoryInventorySlot[] slots;

    private void Start()
    {
        inventory = SystemInventoryInventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<SystemInventoryInventorySlot>();
    }

    private void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
