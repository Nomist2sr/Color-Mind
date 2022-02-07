using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = PlayerCollisions.instance.playa_score.ToString();
    }

    // Update is called once per frame
    void Update()
    { 
    }
}
