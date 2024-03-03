using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Home : MonoBehaviour
{
   // public GameObject panel;
    //two weeks later
    [SerializeField] Work work;
    public GameObject displayText;

    private void Start()
    {
        displayText.SetActive(false);
    }
    //updates player's wages
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Player.Instance.Employed)
        {
            displayText.SetActive(true);
            work.biWeeklySalary();
            work.Taxed();
            Player.Instance.Time = 0; //stands for 2 weeks
        }
    }
}
