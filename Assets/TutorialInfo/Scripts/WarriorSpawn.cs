using UnityEngine;

public class WarriorSpawn : MonoBehaviour
{
    public bool button;

    private void Start()
    {
        button = false;
    }

    public void Guerrero()
    {
        button=true;
        print("hola");
    }

  
}
