using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class _PlasticMoney : MonoBehaviour
{
    public TextMeshProUGUI text;
    private void Awake()
    {
        text.text = "";
    }
    public void AddCredit()
    {
        if (Player.Instance.Employed)
        {
            Player.Instance.CreditCard = true;
            text.text = "";
        }
        else
        {
            text.text = "Get a job before you get a credit card!";
        }
    }

    public void AddDebit()
    {
        if (!Player.Instance.DebitCard)
        {
            Player.Instance.DebitCard = true;
         //   Debug.Log(Player.Instance.DebitCard + "debit card");
        }
       
    }
}
