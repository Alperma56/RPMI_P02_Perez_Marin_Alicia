using UnityEngine;

public class WarriorSpawn : MonoBehaviour
{
    public bool button;

    private void Start()
    {
        button = false;
    }
    private void OnMouseDown()
    {
        button = true;
        print("axe");
    }
}
