using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float speedConstants = speed * Time.deltaTime;
        float hMov = Input.GetAxis("Horizontal") * speedConstants;
        float vMov = Input.GetAxis("Vertical") * speedConstants;
        transform.Translate(new Vector3(hMov, 0, vMov));

    }

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("player collided with enemy");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
        }
    }
}
