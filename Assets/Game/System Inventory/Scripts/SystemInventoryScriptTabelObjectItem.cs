using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = ("Inventory/Item"))]
public class SystemInventoryScriptTabelObjectItem : ScriptableObject
{

    [Header("System Inventory Script Tabel Object Item Variable")]
    public string itemName = "New Item";
    public Sprite itemIcon = null;
    public bool isDefaultItem = false;

    public virtual void Use()
    {
        // * use the item
        // * something might happen

        Debug.Log("Using : " + itemName);
    }
}
