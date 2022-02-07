using UnityEngine;
using UnityEngine.UI;

public class playa_collision : MonoBehaviour
{
    public int playa_score = 0;
    public Choose_color chooseColor;
    public playa_move playa_move;

    private void OnTriggerEnter2D (Collider2D other) {
        Color currentColor = chooseColor.GetComponent<Choose_color>().currentColor;
        bool includeColor = chooseColor.GetComponent<Choose_color>().includeColor;
        if (other.GetComponentInParent<Renderer>().material.color == currentColor && includeColor == true ||
            other.GetComponentInParent<Renderer>().material.color != currentColor && includeColor == false) {
            playa_score++;
        }
        else {
            playa_score--;
        }
        Text textScore = GameObject.Find("Canvas/score").GetComponent<Text>();
        textScore.text = playa_score.ToString();
        playa_move.movementH = 0;
        playa_move.movementV = 0;
        transform.position = new Vector3(0, 0, 0);
        chooseColor.newBlock();
        Debug.Log("hit me again fool!");
    }
}
