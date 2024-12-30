using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private float lastPlayerPosY;
    void Update()
    {
        Vector3 playerPos = player.transform.position;

        // Set the x and z positions to the player's
        Vector3 pos = transform.position;
        pos.x = playerPos.x;
        pos.z = playerPos.z;

        // Calculate Y changes
        if (lastPlayerPosY != 0)
        {
            float yChange = playerPos.y - lastPlayerPosY;
            pos.y += yChange;
        }

        // Make it follow the player
        transform.position = pos;

        // Save the player's last position for calculations in the next frame
        lastPlayerPosY = playerPos.y;
    }
}
