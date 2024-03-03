using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Work : MonoBehaviour
{
    // Start is called before the first frame update
    const float HoursWorked = 8f;
    float time;
    const float payPerHour = 15.20f;
    [SerializeField] TextMeshProUGUI text;

    void Start()
    {
        //empty text
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!Player.Instance.DebitCard)
            {
                text.text = "Get a debit card before you get a job!";
            }
            else
            {
                Player.Instance.Employed = true;
                float playerTime = Player.Instance.Time;
                time += 0.5f;
                text.text = "You're hired!";
                if (time >= HoursWorked && playerTime <= 10)
                {
                    //playerTime += HoursWorked;
                    time = 0;
                    Player.Instance.Time += (uint)HoursWorked;
                    //DailySalary();
                }
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        text.text = "";
    }

    public void biWeeklySalary()
    {
        Player.Instance.Money = payPerHour * 8 * 10;        //15.20 for two weeks that is 10 days, 8 hours long
    }

    public void YearlySalary()
    {
        Player.Instance.AnnualIncome = payPerHour * 40 * 4 * 12;
    }

    //shows how much you are taxed on a daily basis
    public void Taxed()
    {
        float playerMoney = Player.Instance.Money;
        float SSNTax = playerMoney * 0.62f;
        float medicareTax = playerMoney * 0.145f;
        float taxes = SSNTax + medicareTax;

        Player.Instance.SSNtax= SSNTax;
        Player.Instance.MedicareTax = medicareTax;
       // Player.Instance.Money -= taxes;
        Player.Instance.Tax = taxes;
    }
}
