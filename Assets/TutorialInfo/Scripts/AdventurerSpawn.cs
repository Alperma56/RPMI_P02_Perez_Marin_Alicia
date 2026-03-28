using UnityEngine;

public class AdventurerSpawn : MonoBehaviour
{
    public GameObject adventurer;
    public GameObject specialAdventurer;
    public GameObject mage;
    public Transform spawnPoint;
    private Inventory inventory;
    private WarriorSpawn spawnWarrior;
    private MageSpawn mageSpawn;
    private AdventurerButton adventurerSpawn;

    private void Start()
    {
        //busca y guarda en la variable asignada. Tipo que quiero buscar, qué quiero buscar y el componente
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
        spawnWarrior = GameObject.Find("WarriorSpawn").GetComponent<WarriorSpawn>();
        mageSpawn = GameObject.Find("MageSpawn").GetComponent<MageSpawn>();
        //adventurerSpawn = GameObject.Find("AdventurerButton").GetComponent<AdventurerButton>();
    }

    private void OnMouseDown()
    {
        
        if (spawnWarrior.button == true && inventory.axes >= 10)
        { 
            Instantiate(specialAdventurer, spawnPoint.position, spawnPoint.rotation);
            inventory.AddAxes(-10);
        }

       //if (adventurerSpawn.buttonA == true) 
       // {
       //     Instantiate(adventurer, spawnPoint.position, spawnPoint.rotation);
       //     inventory.AddCoins(-10);
       // }
        if (spawnWarrior.button == false)
        {
            if (mageSpawn.buttonM == true && inventory.coins >= 15)
            {
                    Instantiate(mage, spawnPoint.position, spawnPoint.rotation);
                    inventory.AddCoins(-15);
            }
            if (mageSpawn.buttonM ==false && inventory.coins >= 10)
            {
                Debug.Log("spawn");
                Instantiate(adventurer, spawnPoint.position, spawnPoint.rotation);
                inventory.AddCoins(-10);
            }
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
