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

    private void Start()
    {
        movement = false;
        adventurerDamage = GetComponent<Adventurer>().adventurerLife; //nullReference
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("Adventurer")) 
        {
            movement = false;
            //Invoke("Matar", 3);
            animator.SetBool("kill", true);
            adventurerDamage = -100;
            Invoke("Matar2", 3);
            //animator.SetBool("kill", false);
            //movement = true;

            // primero acción y después adventurerlife=0
        }
    }

    //private void OnCollisionExit(Collision collision)
    //{
        
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EndGame"))
        {
            enemySpeed=0;
           // endGameText.gameObject.SetActive(true);

        }

        if (collision.gameObject.CompareTag("Adventurer"))
        {
            enemySpeed = 0;

        }

        if (collision.gameObject.CompareTag("Bullet"))
        {
           
            enemyLife = enemyLife - arrowDamage;
        }

        if (enemyLife <= 0)
        {
            enemySpeed = 0;
            animator.SetBool("dead", true);
            Invoke("Destruir", 3);

        }
    }
    void Update()
    {
        if (movement == true)
        {
            transform.Translate(0, 0, enemySpeed * Time.deltaTime, Space.World);
        }
    }

    public void Destruir() 
    {
        Destroy(gameObject);
        Instantiate(prize, prizePoint.position, prizePoint.rotation);
    }

    //private void Matar()
    //{
    //    animator.SetBool("kill", true);
    //    adventurerDamage = -100;

    //}
    private void Matar2() 
    {
        animator.SetBool("kill", false);
        movement = true;
    }

    public void SpawnAnimationEnded() 
    {
        movement = true;
    }
}
