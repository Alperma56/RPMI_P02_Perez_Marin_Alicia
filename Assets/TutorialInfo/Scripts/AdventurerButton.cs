using UnityEngine;

public class AdventurerButton : MonoBehaviour
{
    public bool buttonA;

    private void Start()
    {
        buttonA = false;
    }

    public void Maga()
    {
        buttonA = true;
        print("aventurero");
    }
}
