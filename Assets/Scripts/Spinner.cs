using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float spinSpeed = 100f;
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 1f;
    [SerializeField] float zAngle = 0f;

    void Update()
    {
        transform.Rotate(xAngle * spinSpeed * Time.deltaTime, yAngle * spinSpeed * Time.deltaTime, zAngle * spinSpeed * Time.deltaTime);
    }
}
