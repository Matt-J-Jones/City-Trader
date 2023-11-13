using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyStock : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject stockToBuy;
    public float stockValue;
    public GameObject currentBalance;
    public float playerBalance;
    public float newBalance;
    
    // Update is called once per frame
    void Update()
    {
        stockValue = float.Parse(stockToBuy.GetComponent<TMPro.TextMeshProUGUI>().text);
        playerBalance = float.Parse(currentBalance.GetComponent<TMPro.TextMeshProUGUI>().text);
    }

    public void OnClick() {
        newBalance = playerBalance - stockValue;
        currentBalance.GetComponent<TMPro.TextMeshProUGUI>().text = newBalance.ToString();
    }
}

