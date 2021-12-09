using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public Transform spawnPoint;
    private GameController gameController;

    [Header("Enemy Explode")]
    public ParticleSystem checkpointActivated;
    public Color activatedColor;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        checkpointActivated = GetComponentInChildren<ParticleSystem>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameController.setCurrentSpawnPoint(spawnPoint);
            CheckPointActive();
        }
    }

    private void CheckPointActive()
    {
        checkpointActivated.GetComponent<Renderer>().material.SetColor("_Color", activatedColor);
        checkpointActivated.Play();
    }
}