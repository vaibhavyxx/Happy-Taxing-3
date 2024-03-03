using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class IRS : MonoBehaviour
{
    //finds total federal income
    public GameObject Panel;
    public Work work;
    public TextMeshProUGUI text;
    float income = 0f;
    float tax=0f;
    private void Start()
    {
        Panel.SetActive(false);
    }

    private void Update()
    {
        //tax = FederalTax();
        //Debug.Log("tax" + tax);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FederalTax();
        SceneManager.LoadScene("End");

    }
    public void FederalTax()
    {
        float federalTax;
        //updates annual salary
        work.YearlySalary();
        income = Player.Instance.AnnualIncome;

        if(income < 12500)
        {
            text.text = "You don't need to file a federal tax";
            //return 0;
        }
        else
        {
            federalTax = income * 0.125f;
            income -= federalTax;
            text.text = "You need to pay $"+ federalTax+ ".";
            //return federalTax;
            Player.Instance.FederalTax = federalTax;
            Player.Instance.SSNtax *= 12;
        }
    }

    public void PayTaxes()
    {
        Player.Instance.AnnualIncome -= tax;
    }
}
