using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Axe : MonoBehaviour
{
    public TextMeshProUGUI hachas;
    private Inventory inventory;

    private void Start()
    {
        //busca y guarda en la variable asignada. Tipo que quiero buscar, qué quiero buscar y el componente
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
    }

    private void Update()
    {
        transform.Rotate(2*Time.deltaTime, 0, 0);
        hachas.text = inventory.axes.ToString();
    }

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
        inventory.axes += 1;
        print(inventory.axes);

    }
}
