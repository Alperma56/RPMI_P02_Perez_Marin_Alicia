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

    private void Start()
    {
        adventurerLife = 100;
        InvokeRepeating("InstantiateArrow", 2, 2);
       
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
        

             if (adventurerLife <= 0)
             {
                animator.SetBool("dead", true);
                //Destroy(gameObject);
             }

        }
    }



}
