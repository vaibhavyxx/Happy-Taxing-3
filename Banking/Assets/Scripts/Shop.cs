using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    private void Start()
    {
        text.text = "";
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!Player.Instance.CreditCard)
            {
                text.text = "Get a credit card before you buy anything!";
            }
            else
            {
                text.text = "You bought airpods for $200!";
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (Player.Instance.CreditCard)
        {
            Player.Instance.Debt -= 200;
            text.text = "";
        }
    }
}
