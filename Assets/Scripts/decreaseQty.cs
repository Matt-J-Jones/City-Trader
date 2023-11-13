using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class decreaseQty : MonoBehaviour
{
    // Start is called before the first frame update
    private TMPro.TextMeshProUGUI textMeshPro;
    public int newCount;
    void Start()
    {
        textMeshPro = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void OnClick()
    {
        newCount = int.Parse(textMeshPro.text);
        if(newCount > 0){
            newCount -= 1;
            textMeshPro.text = newCount.ToString();
        }
    }
}
