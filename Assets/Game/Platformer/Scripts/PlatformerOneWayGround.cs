using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerOneWayGround : MonoBehaviour
{
    [Header("System One Way Ground Object")]
    private PlatformEffector2D effector;

    private void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            effector.rotationalOffset = 180f;
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            Invoke("FlipEffector", 0.25f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            effector.rotationalOffset = 0f;
        }
    }


    private void FlipEffector()
    {
        effector.rotationalOffset = 0f;
    }

}
