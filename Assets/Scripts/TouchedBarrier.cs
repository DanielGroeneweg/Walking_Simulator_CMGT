using Retro.ThirdPersonCharacter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchedBarrier : MonoBehaviour
{
    public GameObject player;
    public GameObject orcDialogue;

    private Movement _movement;

    private void Start()
    {
        _movement = player.GetComponent<Movement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            _movement.EnterDialogue();
            orcDialogue.SetActive(true);
        }
    }
}
