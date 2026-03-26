using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TemplateCard : CardBase
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {      
        damageText = damage.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
