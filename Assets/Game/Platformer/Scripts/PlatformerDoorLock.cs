using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerDoorLock : MonoBehaviour
{

    [Header("Platformer Door Lock Object")]
    public GameObject wall;
    [Header("Platformer Door Lock Variable")]
    private float locationObjective;

    private void Start()
    {
        locationObjective = transform.position.x;
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Objective"))
        {
            collider.gameObject.transform.position = new Vector2(locationObjective, collider.gameObject.transform.position.y);
            Destroy(wall);
        }
    }

}
