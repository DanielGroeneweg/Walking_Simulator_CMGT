using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoxChecker : MonoBehaviour
{
    public UnityEvent onTriggerStay;
    public UnityEvent onTriggerExit;
    public GameObject box;

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.parent.name == box.name) onTriggerStay?.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        onTriggerExit?.Invoke();
    }
}