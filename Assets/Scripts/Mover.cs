using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] int moveSpeed = 7;

    void Start()
    {
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zSpeed = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float ySpeed = 0f;
        transform.Translate(xSpeed, ySpeed, zSpeed);
    }
}
