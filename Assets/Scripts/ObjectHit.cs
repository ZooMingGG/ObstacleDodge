using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    const string PLAYER_TAG = "Player";
    const string HIT_TAG = "Hit";

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(PLAYER_TAG))
        {
            GetComponent<MeshRenderer>().materials[0].color = Color.salmon;
            gameObject.tag = HIT_TAG;
        }
    }
}
