using UnityEngine;


public class playa_move : MonoBehaviour
{
    public float MovementSpeed = 0.5F;
    public  float movementH = 0;
    public  float movementV = 0;
    private void Start()
    {
    }

    private void Update()
    {
        if (movementH == 0 && movementV == 0) {
            movementH = Input.GetAxis("Horizontal");
            movementV = Input.GetAxis("Vertical");
            if (movementH > 0)
                movementH = 1;
            else if (movementH < 0)
                movementH = -1;
            if (movementV > 0)
                movementV = 1;
            else if (movementV < 0)
                movementV = -1;
        }
        else {
            if (movementH != 0) {
                if (movementH < 5)
                    movementH *= 1.015F;
                transform.position += new Vector3(movementH, 0, 0) * Time.deltaTime * MovementSpeed;
            }
            else {
                if (movementV < 4)
                    movementV *= 1.01F;
                transform.position += new Vector3(0, movementV, 0) * Time.deltaTime * MovementSpeed;
            }
        }
    }
}
