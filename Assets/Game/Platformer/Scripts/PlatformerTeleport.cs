using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerTeleport : MonoBehaviour
{
    [Header("Platformer Teleport Object")]
    [SerializeField] private GameObject teleportLocation;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            collider.gameObject.transform.position = teleportLocation.transform.position;
        }
    }
}
