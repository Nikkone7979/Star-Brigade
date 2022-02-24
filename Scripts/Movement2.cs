using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{

    [SerializeField] bool isFacingRight = true;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        if (movement.x < 0 && isFacingRight || movement.x > 0 && !isFacingRight)
            Flip();

    }

    private void Flip()
    {
        //Vector3 playerScale = transform.localScale;
        //playerScale.x = playerScale.x * -1;
        //transform.localScale = playerScale;

        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;

    }
}
