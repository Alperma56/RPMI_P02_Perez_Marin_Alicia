using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalObject : MonoBehaviour
{
    public TextMeshProUGUI endGameText;

    private void Start()
    {
        endGameText.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
       {
            Destroy(gameObject);
            print("choque");
            endGameText.gameObject.SetActive(true);
            SceneManager.LoadScene("Menu");
            // Invoke("LoadScene", 2);
        }
    }

    public void LoadScene() 
    {
        SceneManager.LoadScene("Menu");
    }
}
