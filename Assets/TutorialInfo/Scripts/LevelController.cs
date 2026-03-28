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

        if (totalEnemies >= 10) //Cuando mate a 10 enemigos volverá al menú de inicio, como si ganara el juego
      {
           SceneManager.LoadScene("Menu");
      }
    }
}
