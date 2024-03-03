using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class w2 : MonoBehaviour
{
    public TextMeshProUGUI info;
    
    void Update()
    {
        info.text = "Name: Ashley Johnson\r\nMartial Status: Single\r\nDependentants: None\r\nHours Worked: 16,640hours\r\nTotal Wages: $"+Player.Instance.AnnualIncome+"" +
            "\r\nFederal Tax: $" +Player.Instance.FederalTax;
    }
}
