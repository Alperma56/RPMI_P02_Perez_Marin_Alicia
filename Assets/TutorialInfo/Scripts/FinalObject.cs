using UnityEngine;

public class FinalObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
       {
            Destroy(gameObject);
       }
    }
}
