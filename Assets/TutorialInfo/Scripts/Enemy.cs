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
    private Adventurer adventurer; //contador, tenemos que leer qué aventurero está matando

    private void Start()
    {
        movement = false;
       
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("Adventurer")) 
        {
            movement = false;
            //Invoke("Matar", 3);
            animator.SetBool("kill", true);
            // adventurerDamage = -100;
            other.GetComponent<Adventurer>().adventurerLife = 0;
            Invoke("Matar2", 3);
            //animator.SetBool("kill", false);
            //movement = true;

        }
    }


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
        GameObject.Find("LevelController").GetComponent<LevelController>().enemies += 1;
    }

    
    private void Matar2() 
    {
        animator.SetBool("kill", false);
        movement = true;
    }

    public void Attack() 
    {
    
    }

    public void SpawnAnimationEnded() 
    {
        movement = true;
    }
}
