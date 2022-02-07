using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float _currentTime = 0F;
    float _startingTime = 60F;

    public Text _text;
    public GameEngine endGame;

    void Start()
    {
        _text.text = "60";
        _currentTime = _startingTime;
    }

    public void Update()
    {
        _currentTime -= 1 * Time.deltaTime;
        _text.text = _currentTime.ToString("F1");
        if (_currentTime < 55)
        {
            endGame.EndGame();
        }
    }
}