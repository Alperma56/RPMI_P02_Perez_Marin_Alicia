using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public int enemies;

  
    private void Update()
    {
        if (enemies <= 3)
      {
           SceneManager.LoadScene("Menu");
      }
    }
}
