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
    }

    private void Update()
    {
      
        contador.text = inventory.coins.ToString();

    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        inventory.coins += 1;
        print(inventory.coins);
        
       
    }
}
