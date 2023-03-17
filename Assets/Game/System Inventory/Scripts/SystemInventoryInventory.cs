using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemInventoryInventory : MonoBehaviour
{

    [Header("System Inventory Inventory Variable")]
    [SerializeField] private int inventorySlot;

    [Header("System Inventory Inventory List")]
    public List<SystemInventoryScriptTabelObjectItem> items = new List<SystemInventoryScriptTabelObjectItem>();

    // * delegate metode
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;


    #region Singleton

    [Header("System Inventory Inventory Script")]
    public static SystemInventoryInventory instance;

    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogWarning("More then one instance of Inventory found!");
            return;
        }

        instance = this;
    }

    #endregion Singleton

    public bool AddItem(SystemInventoryScriptTabelObjectItem item)
    {
        if (!item.isDefaultItem)
        {
            if (items.Count >= inventorySlot)
            {

                Debug.LogWarning("Not enough slot!");
                return false;

            }

            items.Add(item);

            if (onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }

        }

        return true;
    }

    public void RemoveItem(SystemInventoryScriptTabelObjectItem item)
    {
        items.Remove(item);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }

}
