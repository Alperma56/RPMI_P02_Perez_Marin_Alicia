using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public int totalEnemies;

  
    private void Update()
    {
        if (totalEnemies <= 3)
      {
           SceneManager.LoadScene("Menu");
      }
    }
}
