using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class companyBio : MonoBehaviour
{
    public string companyName;
    public string companyInfo;
    public TextMeshProUGUI nameElement;
    public TextMeshProUGUI bioElement;
    
    // Start is called before the first frame update
    void Start()
    {
        nameElement.text = "";
        bioElement.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
