using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoxChecker : MonoBehaviour
{
    public UnityEvent onTriggerStay;
    public UnityEvent onTriggerExit;
    public string boxName;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == boxName) onTriggerStay?.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        onTriggerExit?.Invoke();
    }
}