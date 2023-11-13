using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class updateValue : MonoBehaviour
{
    public TextMeshProUGUI tmpElement;
    public TextMeshProUGUI tmpChange;
    public float tmpValue = 0f;
    public Color positive = new Color(255,255,255,255);
    public Color negative = new Color(255,0,0,255);


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTMPElement", 0f, Random.Range(2f,4f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateTMPElement()
    {
        // Generate a random float between -1 and 1
        float randomFloat = Random.Range(-10f, 5f);

        // Update the TMP element value
        if ((tmpValue + randomFloat) < 0)
        {
            tmpValue = 0.01f;
        } else {
            tmpValue += randomFloat;
        }

        // Update the TMP element text
        tmpElement.text = tmpValue.ToString("F2");
        tmpChange.text = randomFloat.ToString("F2");
        if(randomFloat < 0){ tmpChange.color = negative; } else { tmpChange.color = positive; }
        if(tmpValue < 0){ tmpElement.color = negative; } else { tmpElement.color = positive; }
    }
}
