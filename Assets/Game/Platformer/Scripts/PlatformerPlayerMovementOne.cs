using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerPlayerMovementOne : MonoBehaviour
{
    [Header("Player Movement Variable")]
    [SerializeField] private float playerMoveSpeed;
    [SerializeField] private float jumpPower;
    private float dirX;


    [Header("Player Movement Object")]
    [SerializeField] private BoxCollider2D playerCollider;
    [SerializeField] LayerMask jumpableGround;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        PlayerMovement();
        JumpPlayer();
    }

    // * cara player bergerak
    private void PlayerMovement()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * playerMoveSpeed, rb.velocity.y);
    }

    // * mengatur cara player lompat
    public void JumpPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    }

    // * cek player apakah menyentuh tanah?
    public bool IsGrounded()
    {
        return Physics2D.BoxCast(playerCollider.bounds.center, playerCollider.bounds.size, 0f, Vector2.down, 0.1f, jumpableGround);
    }


}
