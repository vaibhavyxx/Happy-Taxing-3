using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopping : MonoBehaviour
{
    // buying
    private float totalAmount = 0;
    private bool isBuying = false;
    private bool isCredit = false;
    private bool isDebit = false;

    // items
    private Dictionary<GameObject, float> items = new Dictionary<GameObject, float>();


    void Start()
    {

    }

    /// <summary> 
    /// when player clicks on item, the price will be added to total
    /// </summary>
    /// <param name="price">price to add to total</param>
    public void AddToTotal(float price)
    {
        totalAmount += price;
    }

    /// <summary>
    /// when the player presses the buy button, prompt payment method
    /// </summary>
    public void Buy()
    {
        // if buy button is pressed, show payment options
        if (!isBuying)
        {
            // depending on credit or debit, subtract or add to account
            if (!isCredit)
            {
                // add
            }
            else if (!isDebit)
            {
                // subtract
            }

        }
    }

}