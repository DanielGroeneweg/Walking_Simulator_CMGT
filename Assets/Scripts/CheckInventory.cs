using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckInventory : MonoBehaviour
{
    public Inventory inventory;
    public UnityEvent match;
    public UnityEvent noMatch;
    public void CheckForItem(string itemToCheck)
    {
        if (inventory.inventoryItems.Count > 0)
        {
            for (int i = inventory.inventoryItems.Count - 1; i >= 0; i--)
            {
                if (itemToCheck == inventory.inventoryItems[i].ToString())
                {
                    match?.Invoke();
                    return;
                }
            }
        }

        noMatch?.Invoke();
    }
}