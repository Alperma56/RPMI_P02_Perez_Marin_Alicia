using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private bool pause;

    private void Start()
    {
        pause = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause)
            {
                pause = false;
                Time.timeScale = 1.0f;
            }
            else
            {
                pause = true;
                Time.timeScale = 0.0f;
            }
        }
        
    }
    public void LoadGameScene() 
    {
        SceneManager.LoadScene("Game");
    }
}
