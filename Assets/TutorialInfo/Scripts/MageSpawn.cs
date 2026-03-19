using UnityEngine;

public class MageSpawn : MonoBehaviour
{
    public bool buttonM;

    private void Start()
    {
        buttonM = false;
    }

    public void Maga()
    {
        buttonM = true;
        print("hola");
    }
}
