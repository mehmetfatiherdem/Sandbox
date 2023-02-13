using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    Rigidbody objectRb;

    private void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRb.AddForce(speed * Vector3.back);
    }
}
