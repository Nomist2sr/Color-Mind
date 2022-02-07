using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float _currentTime = 0F;
    float _startingTime = 60F;

    public Text timerText;
    public GameEngine endGame;

    void Start()
    {
        timerText.text = "60";
        _currentTime = _startingTime;
    }

    public void Update()
    {
        _currentTime -= 1 * Time.deltaTime;
        timerText.text = _currentTime.ToString("F1");
        if (_currentTime < 0)
        {
            endGame.EndGame();
        }
    }
}