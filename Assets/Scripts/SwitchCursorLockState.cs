using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCursorLockState : MonoBehaviour
{
    public void SwitchLockState(string lockMode)
    {
        switch (lockMode)
        {
            case "Locked":
                Cursor.lockState = CursorLockMode.Locked;
                break;
            case "Confined":
                Cursor.lockState = CursorLockMode.Confined;
                break;
            case "None":
                Cursor.lockState = CursorLockMode.None;
                break;
        }
    }
}