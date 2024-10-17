using UnityEngine;
using TMPro;
using System.Collections;

public class PlayerPlatform : Platform
{
    private Vector2 _direction;
    public bool canMove = true;
    private KeyCode[] availableKeys =
{
        KeyCode.A, KeyCode.B, KeyCode.C, KeyCode.D, KeyCode.E, KeyCode.F, KeyCode.G, KeyCode.H,
        KeyCode.I, KeyCode.J, KeyCode.K, KeyCode.L, KeyCode.M, KeyCode.N, KeyCode.O, KeyCode.P,
        KeyCode.Q, KeyCode.R, KeyCode.S, KeyCode.T, KeyCode.U, KeyCode.V, KeyCode.W, KeyCode.X,
        KeyCode.Y, KeyCode.Z
    };

    private KeyCode keyUp; 
    private KeyCode keyDown;

    public TextMeshProUGUI controlText;
    private void Start()
    {
        SelectRandomKeys();
        StartCoroutine(UpdateKeysRandomly());
    }


    private void Update() 
    {
        if (canMove)
        {
            if (Input.GetKey(keyUp)) 
            {
                _direction = Vector2.up;
            } 
            else if (Input.GetKey(keyDown)) 
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

            newPosition.y = Mathf.Clamp(newPosition.y, -5.8f, 6.24f);

            _rigidbody.MovePosition(newPosition);
        }
    }

    public void SelectRandomKeys()
    {
        keyUp = availableKeys[Random.Range(0, availableKeys.Length)];
        keyDown = availableKeys[Random.Range(0, availableKeys.Length)];

        while (keyUp == keyDown)
        {
            keyDown = availableKeys[Random.Range(0, availableKeys.Length)];
        }


        if (controlText != null)
        {
            controlText.text = $"Up: {keyUp}\nDown: {keyDown}";
        }
    }

    private IEnumerator UpdateKeysRandomly()
    {
        while (true)
        {
            float waitTime = Random.Range(5f, 15f);
            yield return new WaitForSeconds(waitTime);
            SelectRandomKeys();
        }
    }
}
