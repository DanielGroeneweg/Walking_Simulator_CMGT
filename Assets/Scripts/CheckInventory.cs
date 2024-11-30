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
        if (itemToCheck == inventory.itemInInventory.ToString()) match?.Invoke();
        else noMatch?.Invoke();
    }
}