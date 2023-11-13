using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeNameAndBio : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject companyNameText;
    public String companyName;
    private TMPro.TextMeshProUGUI TMPCName;

    public GameObject companyBioText;
    public String companyBio;
    private TMPro.TextMeshProUGUI TMPCBio;
    
    void Start()
    {
        TMPCName = companyNameText.GetComponent<TMPro.TextMeshProUGUI>();
        TMPCBio = companyBioText.GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void OnMouseEnter()
    {
          TMPCName.text = companyName;
          TMPCBio.text = companyBio;
    }

    public void OnMouseExit()
    {
          TMPCName.text = "";
          TMPCBio.text = "";
    }
}
