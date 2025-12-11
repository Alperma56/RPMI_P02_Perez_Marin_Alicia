using UnityEngine;

public class Collider : MonoBehaviour
{
    public float arrowSpeed;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        transform.Translate(0,  -arrowSpeed * Time.deltaTime, 0);
    }
}
