using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public enum itemTypes { Key, None }
    public List<itemTypes> inventoryItems;
    private void Awake()
    {
        inventoryItems = new List<itemTypes>();
    }
    public void AddItem(string itemType)
    {
        switch (itemType)
        {
            case "Key":
                inventoryItems.Add(itemTypes.Key);
                return;
        }

        Debug.LogError(itemType + " is not a valid item! (Have you spelled it correctly?)");
    }

    public void RemoveItem(string itemType)
    {
        if (inventoryItems.Count > 0)
        {
            for (int i = inventoryItems.Count - 1; i >= 0; i--)
            {
                if (inventoryItems[i].ToString() == itemType)
                {
                    inventoryItems.Remove(inventoryItems[i]);
                    return;
                }
            }
        }

        Debug.LogError("Item Was Not Found In Inventory!");
    }

    public void EmptyInventory()
    {
        inventoryItems.Clear();
        inventoryItems.Add(itemTypes.None);
    }
}
