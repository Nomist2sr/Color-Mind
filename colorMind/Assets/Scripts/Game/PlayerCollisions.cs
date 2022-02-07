using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisions : MonoBehaviour
{
    public static PlayerCollisions instance;
    public int playa_score = 0;
    public SetAllColors chooseColor;
    public PlayerMoves playa_move;

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnTriggerEnter2D (Collider2D other) {
        Color currentColor = chooseColor.GetComponent<SetAllColors>().currentColor;
        bool includeColor = chooseColor.GetComponent<SetAllColors>().includeColor;
        if (other.GetComponentInParent<Renderer>().material.color == currentColor && includeColor == true ||
            other.GetComponentInParent<Renderer>().material.color != currentColor && includeColor == false) {
            playa_score++;
        }
        else
        {
            playa_score--;
        }
        Text textScore = GameObject.Find("Canvas/Score").GetComponent<Text>();
        textScore.text = playa_score.ToString();
        playa_move.movementH = 0;
        playa_move.movementV = 0;
        transform.position = new Vector3(0, 0, 0);
        chooseColor.newBlock();
    }
}