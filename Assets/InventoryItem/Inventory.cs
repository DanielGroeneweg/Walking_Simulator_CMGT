using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public enum itemTypes { Key, None }
    public itemTypes itemInInventory = itemTypes.None;
    public void SetItem(string itemType)
    {
        switch (itemType)
        {
            case "Key":
                itemInInventory = itemTypes.Key;
                return;
            case "None":
                itemInInventory = itemTypes.None;
                return;
        }

        Debug.LogError(itemType + " is not a valid item! (Have you spelled it correctly?)");
    }

    public void EmptyInventory()
    {
        itemInInventory = itemTypes.None;
    }
}
