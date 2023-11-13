using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateBalance : MonoBehaviour
{
    // Start is called before the first frame update
    private TMPro.TextMeshProUGUI textMeshPro;
    public float balance = 0f;
    void Start()
    {
        textMeshPro = GetComponent<TMPro.TextMeshProUGUI>();
        textMeshPro.text = balance.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
