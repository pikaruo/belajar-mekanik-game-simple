using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemInventoryInventorySlot : MonoBehaviour
{

    [Header("System Inventory Inventory Slot Object")]
    [SerializeField] private Image icon;
    [SerializeField] private Button removeButton;

    [Header("System Inventory Inventory Slot Script")]
    private SystemInventoryScriptTabelObjectItem item;

    public void AddItem(SystemInventoryScriptTabelObjectItem newItem)
    {
        item = newItem;

        icon.sprite = item.itemIcon;
        icon.enabled = true;
        removeButton.interactable = true;
    }

    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

    public void OnRemoveButton()
    {
        SystemInventoryInventory.instance.RemoveItem(item);
    }

    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
        }
    }
}
