using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
