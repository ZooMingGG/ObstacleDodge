using UnityEngine;

public class Scorer : MonoBehaviour
{
    const string HIT_TAG = "Hit";
    int hitCount = 0;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(HIT_TAG)) return;

        hitCount++;
        Debug.Log($"Collision Detected. Hit Count: {hitCount}");
    }
}
