using UnityEngine;

public class PlayerPlatform : Platform
{
    private Vector2 _direction;
    public bool canMove = true;

    private void Update() 
    {
        if (canMove)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) 
            {
                _direction = Vector2.up;
            } 
            else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) 
            {
                _direction = Vector2.down;
            } 
            else 
            {
                _direction = Vector2.zero;
            }
        }
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            Vector2 newPosition = _rigidbody.position + _direction * this.speed * Time.fixedDeltaTime;

            newPosition.y = Mathf.Clamp(newPosition.y, -8.75f, 8.75f);

            _rigidbody.MovePosition(newPosition);
        }
    }
}
