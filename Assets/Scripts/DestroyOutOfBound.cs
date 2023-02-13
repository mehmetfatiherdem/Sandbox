using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    readonly float zBoundUp = 5.10f;
    readonly float zBoundDown = -5.90f;
    // Update is called once per frame
    void Update()
    {
        float zPos = transform.position.z;
        if (zPos < zBoundDown || zPos > zBoundUp)
        {
            Destroy(gameObject);
        }
    }
}
