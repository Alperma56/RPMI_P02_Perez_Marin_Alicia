using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private int enemies;

    public void CountEnemies(/*int enemiesToAdd*/)
    {
        //enemies = GameObject.Find("Enemy").GetComponent<Enemy>();
        enemies += 1;
    }

    private void Update()
    {
        if (enemies <= 3)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
