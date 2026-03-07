using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public int totalEnemies;
    public Inventory inventory;

    private void Start()
    {
        inventory= GameObject.Find("Inventory").GetComponent<Inventory>();
    }
    
    private void Update()
    {
        totalEnemies = inventory.enemies;

        if (totalEnemies >= 5)
      {
           SceneManager.LoadScene("Menu");
      }
    }
}
