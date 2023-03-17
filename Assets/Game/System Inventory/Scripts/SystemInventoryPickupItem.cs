using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemInventoryPickupItem : MonoBehaviour
{

    [Header("System Inventory Pickup Item Script")]
    [SerializeField] private SystemInventoryScriptTabelObjectItem item;

    public void Pickup()
    {
        Debug.Log("Item Pickup : " + item.itemName);
        bool wasPickedUp = SystemInventoryInventory.instance.AddItem(item);

        if (wasPickedUp)
        {
            Debug.LogWarning("Item destory!");
        }

    }
}
