using UnityEngine;

public class AdventurerSpawn : MonoBehaviour
{
    public GameObject adventurer;
    public Transform spawnPoint;
    private Inventory inventory;

    private void Start()
    {
        //busca y guarda en la variable asignada. Tipo que quiero buscar, qué quiero buscar y el componente
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
    }

    private void OnMouseDown()
    {
       
        Debug.Log("spawn");
        Instantiate(adventurer, spawnPoint.position, spawnPoint.rotation);

    }
}
