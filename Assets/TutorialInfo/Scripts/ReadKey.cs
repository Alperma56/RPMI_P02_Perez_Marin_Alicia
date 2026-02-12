using UnityEngine;

public class ReadKey : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.GetInt("tecla h", -1) == 5) 
        {
            print("pulsó h");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)) 
        {
            PlayerPrefs.SetInt("tecla h", 5);
            PlayerPrefs.Save(); //me aseguro de que lo guarde al momento
        }
    }
}
