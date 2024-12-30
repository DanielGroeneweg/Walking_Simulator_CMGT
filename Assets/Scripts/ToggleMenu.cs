using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public SwitchCursorLockState cursorScript;

    private bool isPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) DisableMenu();
            else EnableMenu();
        }
    }

    public void EnableMenu()
    {
        pauseMenu.SetActive(true);
        cursorScript.SwitchLockState("Confined");
        isPaused = true;
    }

    public void DisableMenu()
    {
        pauseMenu.SetActive(false);
        cursorScript.SwitchLockState("Locked");
        isPaused = false;
    }
}
