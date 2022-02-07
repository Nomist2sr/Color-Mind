using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float _currentTime = 0F;
    public static Timer instance;
    float _startingTime = 60F;

    [SerializeField] Text _text;

    void Start()
    {
        _currentTime = _startingTime;
    }

    void Update()
    {
        _currentTime -= 1 * Time.deltaTime;
        _text.text = _currentTime.ToString("F1");

        if (_currentTime <= 0)
        {
            _currentTime = 0;
        }
    }
}