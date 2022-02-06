using UnityEngine;

public class playa_collision : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D other) {
        Debug.Log("hit me again fool!");
    }
}
