using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 pos = transform.position;
        pos.x = playerPos.x;
        pos.z = playerPos.z;
        transform.position = pos;
    }
}
