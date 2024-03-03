using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerInfo : MonoBehaviour
{
    // fields
    [SerializeField]
    private TextMeshProUGUI text;

    private string creditText = "Credit Card Required";
    private string debitText = "Debit Card Required";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.Instance.CreditCard)
        {
            creditText = "$" + Player.Instance.Debt.ToString();
        }
        if (Player.Instance.DebitCard)
        {
            debitText = "$" + Player.Instance.Money.ToString();
        }
        text.text = "Funds: " + debitText + "\tTime Right Now: " + Player.Instance.Time + ":00" + 
                    "\tDebt: " + creditText+ "\nTaxes: "+ Player.Instance.Tax +"\n\t SSN: "+Player.Instance.SSNtax+
                    "\n\t Medicare: "+Player.Instance.MedicareTax;
    }
}
