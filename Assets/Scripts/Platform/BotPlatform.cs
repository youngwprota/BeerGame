using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPlatform : Platform
{
    public Rigidbody2D ball;

    public bool canMove = true;
    public float reactionTime = 0.5f; 

    private void FixedUpdate()
    {
        if (canMove)
        {
            Vector2 targetPosition = ball.position + ball.velocity * reactionTime;

            targetPosition.y = Mathf.Clamp(targetPosition.y, -5f, 5f); 

            Vector2 direction = (targetPosition - (Vector2)this.transform.position).normalized;
            _rigidbody.velocity = new Vector2(0, direction.y * speed);
        }
    }
}
