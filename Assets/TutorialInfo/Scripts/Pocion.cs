using UnityEngine;

public class Pocion : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
    //la intención es que se sepa cuando se ha cogido y de ahí añadirle vida extra al aventurero
}
