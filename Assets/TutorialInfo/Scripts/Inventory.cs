using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{
    public int coins;
    public TextMeshProUGUI contador;
    public TextMeshProUGUI hachas;
    public int axes;

    private void Start()
    {
        contador.text = coins.ToString();
    }
    public void AddCoins(int coinsToAdd) 
    {
        coins += coinsToAdd;
        contador.text = coins.ToString();
    }

    public void AddAxes(int axesToAdd)
    {
        axes += axesToAdd;
        hachas.text = axes.ToString();
    }

}
