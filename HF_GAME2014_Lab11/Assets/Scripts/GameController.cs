using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform player;
    public Transform currentSpawnPoint;

    void Start()
    {
        player.position = currentSpawnPoint.position;
    }

    public void setCurrentSpawnPoint(Transform newSpawnPoint)
    {
        currentSpawnPoint = newSpawnPoint;
    }
}