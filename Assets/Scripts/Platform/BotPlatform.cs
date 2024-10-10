using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotPlatform : Platform
{
    public Rigidbody2D ball;

    public bool canMove = true;
    public float reactionTime = 0.5f; // Время реакции бота

    private void FixedUpdate()
    {
        if (canMove)
        {
            // Вычисляем целевую позицию на основе текущей позиции мяча и его скорости
            Vector2 targetPosition = ball.position + ball.velocity * reactionTime;

            // Ограничиваем движение бота в пределах экрана
            targetPosition.y = Mathf.Clamp(targetPosition.y, -5f, 5f); // Замените -5f и 5f на границы вашего игрового поля

            // Двигаем платформу к целевой позиции
            Vector2 direction = (targetPosition - (Vector2)this.transform.position).normalized;
            _rigidbody.velocity = new Vector2(0, direction.y * speed);
        }
    }
}
