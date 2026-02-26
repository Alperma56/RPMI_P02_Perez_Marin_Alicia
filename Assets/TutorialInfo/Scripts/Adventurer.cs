using UnityEngine;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements;

public class Adventurer : MonoBehaviour
{
    public int adventurerLife;
    public int enemyDamage;
    public GameObject arrow;
    public Transform spawnPoint;
    public Animator animator;
    private bool shooting;
    public float distance;

    private void Start()
    {
        adventurerLife = 100;
       // InvokeRepeating("InstantiateArrow", 2, 2);
        shooting = false;
        //distance = GetComponent<BoxCollider>().size.z;
    }

    private void Update()
    {
        bool enemyInFront = Physics.Raycast(spawnPoint.position, transform.forward, distance, LayerMask.GetMask("Enemies"));

        if (adventurerLife <= 0)
        {
            animator.SetBool("Dead", true);
            Invoke("DestruirAventurero", 3);
            CancelInvoke("InstantiateArrow");
        }
        if (shooting) // if (shooting ==true)
        {
            if (!enemyInFront) 
            {
                shooting = false;
                CancelInvoke("InstantiateArrow");
            }
        }

        else //if (!shooting)
        {
            shooting = true;
            InvokeRepeating("InstantiateArrow", 2, 2);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(spawnPoint.position, 0.2f);
        Gizmos.DrawRay(spawnPoint.position, distance*transform.forward);
    }

    private void InstantiateArrow() 
    {
        Instantiate(arrow, spawnPoint.position, spawnPoint.rotation);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))

        {
            adventurerLife = adventurerLife - enemyDamage;
        }
    }

    public void DestruirAventurero()
    {
        Destroy(gameObject);
        
    }

}
