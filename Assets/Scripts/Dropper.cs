using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeToWait = 3;

    MeshRenderer meshRenderer;
    Rigidbody rigidBody;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time >= timeToWait)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
