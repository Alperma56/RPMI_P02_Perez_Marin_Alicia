using UnityEngine;

public class AdventurerSpawn : MonoBehaviour
{
    public GameObject adventurer;
    public GameObject specialAdventurer;
    public Transform spawnPoint;
    private Inventory inventory;

    private void Start()
    {
        //busca y guarda en la variable asignada. Tipo que quiero buscar, qué quiero buscar y el componente
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
        
    }

    private void OnMouseDown()
    {
        if (inventory.axes >= 10) 
        {
            Instantiate(specialAdventurer, spawnPoint.position, spawnPoint.rotation);
            inventory.AddAxes(-10);
        }
        
        else if (inventory.coins >= 10)
        {
            Debug.Log("spawn");
            Instantiate(adventurer, spawnPoint.position, spawnPoint.rotation);
            inventory.AddCoins(-10);
        }

        if (inventory.coins < 10)
        {
            print("No tienes suficientes monedas");
        }

        if (inventory.axes < 10)
        {
            print("No tienes suficientes hachas");
        }
    }
}
