using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchedBarrier : MonoBehaviour
{
    public GameObject orcDialogue;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.Confined;
            orcDialogue.SetActive(true);
        }
    }
}