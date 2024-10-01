using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    public float speed = 200.0f;
    private Rigidbody2D _rigidbody;

    public Transform playerPlatform; 
    public Transform botPlatform; 

    private PlayerPlatform platformPlayerScript;
    private BotPlatform platformBotScript;
    private  Score score;
    public bool ballOut; 

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        platformPlayerScript = playerPlatform.GetComponent<PlayerPlatform>();
        platformBotScript = botPlatform.GetComponent<BotPlatform>();
        score = new Score();
        AddStartingForce();
    }

    private void Update() 
    {
        if (ballOut)
        {
            ShootBall();
        }
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5F ? Random.Range(-1.0f, -0.5f) :
        Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * this.speed);
    }

    private void ForceVector()
    {
        _rigidbody.velocity = Vector2.zero; 
        _rigidbody.AddForce(new Vector2(-1 * _rigidbody.position.x, 0).normalized * this.speed);
    }   

    private void OnTriggerEnter2D(Collider2D other) 
    {   
        if (other.CompareTag("SideWall")) 
        {
            ResetBallPosition();
        }
        if (other.CompareTag("Cup")) 
        {
            if (_rigidbody.position.x < 0)
            {
                Destroy(other.gameObject);
                score.IncreaseBotScore();
                Debug.Log("Bot score: " + score.getBotScore());
            }
            else
            {
                Destroy(other.gameObject);
                score.IncreasePlayerScore();
                Debug.Log("Player score: " + score.getPlayerScore());
            }
        }
    }

    private void ResetBallPosition() 
    {
        ballOut = true; 
        _rigidbody.velocity = Vector2.zero; 

        if (_rigidbody.position.x < 0)
        {
            platformPlayerScript.canMove = false; 
            _rigidbody.position = new Vector2(playerPlatform.position.x + 1.0f, playerPlatform.position.y);
        }
        else 
        {
            platformBotScript.canMove = false; 
            _rigidbody.position = new Vector2(botPlatform.position.x - 1.0f, botPlatform.position.y);
        }
    }

    private void ShootBall() 
    {
        if (_rigidbody.position.x < 0)
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                ForceVector(); 
                platformPlayerScript.canMove = true; 
                ballOut = false; 
            }
        }
        else
        {
            StartCoroutine(BotLaunchBall());
        }
    }

    private IEnumerator BotLaunchBall() 
    {
        platformBotScript.canMove = true; 
        ballOut = false; 
        yield return new WaitForSeconds(1f);
        ForceVector(); 
    }
}
