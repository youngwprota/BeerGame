using UnityEngine;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Image imageComponent;
    public AudioSource audioSource;
    public float botWidth;
    public float ballSpeed;

    public GameObject bot;
    public Ball ball;

    void Start()
    {
        if (GameData.botImage != null)
        {
            imageComponent.sprite = GameData.botImage;
        }

        if (GameData.botAudio != null)
        {
            audioSource.clip = GameData.botAudio;
            audioSource.Play();
        }

        bot.transform.localScale = new Vector3(bot.transform.localScale.x, GameData.botWidth, bot.transform.localScale.z);
        ball.speed = GameData.ballSpeed;

    }
}
