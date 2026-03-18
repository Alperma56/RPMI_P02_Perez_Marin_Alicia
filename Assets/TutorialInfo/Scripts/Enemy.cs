using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float enemySpeed;
    public int enemyLife;
    public int arrowDamage;
    public GameObject prize;
    public Transform prizePoint;
    public Animator animator;
    private bool movement;
    public float adventurerDamage;
    private Adventurer adventurerToAttack; 
    private Inventory inventory;
    public GameObject deadParticle;


    private void Start()
    {
        movement = false;
       
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("Adventurer")) 
        {
            movement = false;
            animator.SetBool("kill", true);
            other.GetComponent<Adventurer>().adventurerLife = 0;
            Invoke("Matar2", 3);
           
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EndGame"))
        {
            enemySpeed=0;
        }


        if (collision.gameObject.CompareTag("Bullet"))
        {
            enemyLife = enemyLife - arrowDamage;
        }

        if (enemyLife <= 0)
        {
            enemySpeed = 0;
            animator.SetBool("dead", true);
            deadParticle.gameObject.SetActive(true);
            Invoke("Destruir", 3);
        }
    }
    void Update()
    {
        if (movement == true)
        {
            RaycastHit hitInfo;

            if (Physics.Raycast(transform.position, transform.forward, out hitInfo, 0.5f, LayerMask.GetMask("Heroes")))
            {
                if (hitInfo.collider!=null) 
                { 
                    adventurerToAttack=hitInfo.collider.GetComponent<Adventurer>();
                }
                movement = false;
                //animator.SetBool("kill", true);
            }
            
            transform.Translate(0, 0, enemySpeed * Time.deltaTime, Space.World);
        }
    }

    public void Destruir() 
    {
        Destroy(gameObject);
        Instantiate(prize, prizePoint.position, prizePoint.rotation);
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
        inventory.AddEnemies(1);
    }

    
    private void Matar2() 
    {
        animator.SetBool("kill", false);
        movement = true;
    }

    public void Attack() 
    {
        //if (adventurerToAttack != null) 
        //{
        //adventurerToAttack.enemyDamage -= 0;
        //}
    }

    public void SpawnAnimationEnded() 
    {
        movement = true;
    }

    //public void BackToMenu() 
    //{
    //    GameObject.Find("LevelController").GetComponent<LevelController>();
        
    //}
}
