using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sellStock : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject stockToBuy;
    public float stockValue;
    public GameObject currentBalance;
    public float playerBalance;
    public float newBalance;
    public GameObject qtyHeld;
    public int qtyStocksHeld;
    void Update()
    {
        stockValue = float.Parse(stockToBuy.GetComponent<TMPro.TextMeshProUGUI>().text);
        playerBalance = float.Parse(currentBalance.GetComponent<TMPro.TextMeshProUGUI>().text);
        qtyStocksHeld = int.Parse(qtyHeld.GetComponent<TMPro.TextMeshProUGUI>().text);
    }

    public void OnClick() {
        if (qtyStocksHeld > 0){
            newBalance = playerBalance + stockValue;
            currentBalance.GetComponent<TMPro.TextMeshProUGUI>().text = newBalance.ToString("F2");
        }
    }
}
