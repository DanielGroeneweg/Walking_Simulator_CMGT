using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedTurnOff : MonoBehaviour
{
    public void DelayedDisable(int delay)
    {
        Invoke(nameof(DisableObject), delay);
    }
    public void DisableObject()
    {
        gameObject.SetActive(false);
    }
}