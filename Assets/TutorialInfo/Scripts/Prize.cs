using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class Prize : MonoBehaviour
{
    public TextMeshProUGUI contador;
    private Inventory inventory;

    private void Start()
    {
        //busca y guarda en la variable asignada. Tipo que quiero buscar, qué quiero buscar y el componente
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
        contador = GameObject.Find("Contador_monedas").GetComponent<TextMeshProUGUI>();
    }

  
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        inventory.AddCoins(5);
    }
}
