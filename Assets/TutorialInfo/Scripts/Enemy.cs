using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float enemySpeed;
    public TextMeshProUGUI endGameText;
    public int enemyLife;
    public int arrowDamage;
    public GameObject prize;
    public Transform prizePoint;
   


    private void Start()
    {
        endGameText.gameObject.SetActive(false);
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EndGame"))
        {
            enemySpeed=0;
            endGameText.gameObject.SetActive(true);

        }

        if (collision.gameObject.CompareTag("Bullet"))
        {
            enemyLife = enemyLife - arrowDamage;
        }
    }
    void Update()
    {
        transform.Translate(0, 0, enemySpeed * Time.deltaTime, Space.World);

        if (enemyLife <= 0)
        {
            Destroy(gameObject);
            Instantiate(prize, prizePoint.position, prizePoint.rotation);
        }
    }
}
