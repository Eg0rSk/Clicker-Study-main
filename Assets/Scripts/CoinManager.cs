using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public TMP_Text coinText;
    public int coins;

    public void AddCoin()
    {
        coins++;
        coinText.text = "Coins: " + coins;
    }
}
