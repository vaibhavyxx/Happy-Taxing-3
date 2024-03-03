using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _PlasticMoney : MonoBehaviour
{
    public void AddCredit()
    {
        Player.Instance.CreditCard = true;
       // Debug.Log(Player.Instance.CreditCard + "credit card");
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
