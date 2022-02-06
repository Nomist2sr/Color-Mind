using UnityEngine;


public class playa_move : MonoBehaviour
{
    public float MovementSpeed = 0.5F;
    public  float movement = 0;
    private void Start()
    {
    }

    private void Update()
    {
        if (movement == 0) {
            movement = Input.GetAxis("Horizontal");
            if (movement > 0)
                movement = 1;
            else if (movement < 0)
                movement = -1;
        }
        else {
            if (movement < 4)
                movement *= 1.01F;
            transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        }
    }
}
