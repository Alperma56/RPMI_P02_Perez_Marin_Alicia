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
    private float distance;

    private void Start()
    {
        adventurerLife = 100;
       // InvokeRepeating("InstantiateArrow", 2, 2);
       shooting = false;
        distance = GetComponent<BoxCollider>().size.z;
       
    }

    private void Update()
    {
        if (shooting) // if (shooting ==true)
        {
            if (!Physics.Raycast(spawnPoint.position, transform.forward,float.MaxValue, LayerMask.GetMask("Enemies"))) //raycast no choca con nada
            {
                shooting = false;
                CancelInvoke("InstantiateArrow");
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(spawnPoint.position, 0.2f);
        Gizmos.DrawRay(spawnPoint.position, transform.forward);
    }

    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (shooting == false) 
            {
               shooting=true;
               InvokeRepeating("InstantiateArrow", 2, 2);
            }
           
        }
    }

    //private void OnTriggerExit(UnityEngine.Collider other)
    //{
    //    if (other.gameObject.CompareTag("Enemy"))
    //    {

    //        CancelInvoke;
    //    }
    //}


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

                animator.SetBool("Dead", true);
                Invoke("DestruirAventurero", 3);
                CancelInvoke("InstantiateArrow");
             }

        }
    }

    public void DestruirAventurero()
    {
        Destroy(gameObject);
        
    }

}
