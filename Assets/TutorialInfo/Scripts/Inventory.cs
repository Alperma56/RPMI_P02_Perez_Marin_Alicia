using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;


public class Inventory : MonoBehaviour
{
    public int coins;
    public TextMeshProUGUI contador;
    public TextMeshProUGUI hachas;
    public int axes;
    public TextMeshProUGUI countEnemies;
    public int enemies;

    private void Start()
    {
        contador.text = coins.ToString();
        hachas.text = hachas.ToString();
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

    public void AddEnemies(int enemiesToAdd) 
    {
        enemies += enemiesToAdd;
        countEnemies.text = enemies.ToString();
    }

}
