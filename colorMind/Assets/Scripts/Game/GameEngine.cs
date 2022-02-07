using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEngine : MonoBehaviour
{
    public void EndGame()
    {
        Restart();
    }

    void Restart()
    {
        SceneManager.LoadScene("Menu");
    }
}
