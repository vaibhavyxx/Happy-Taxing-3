using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; set; }

    private void Awake()
    { 
        // if instance exists thats not me, delete myself
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else // if no other instances
        {
            Instance = this;
        }
    }

    // fields

    private bool creditCard = false;
    private bool debitCard = false;
    private bool employed = false;
    private float money = 0;
    private float debt = 0;
    // current world time
    private uint time = 8;
    private float tax=0;
    float ssnTax;
    float medicareTax;

    public float SSNtax
    {
        get { return ssnTax; }
        set { ssnTax = value; }
    }

    public float MedicareTax
    {
        get { return medicareTax; } 
        set { medicareTax = value;}
    }

    // properties
    public bool CreditCard
    {
        get
        {
            return creditCard;
        }
        set
        {
            creditCard = value;
        }
    }

    public float Tax
    {
        get
        {
            return tax;
        }
        set { tax = value; }
    }

    public bool DebitCard
    {
        get
        {
            return debitCard;
        }
        set
        {
            debitCard = value;
        }
    }

    public bool Employed
    {
        get
        {
            return employed;
        }
        set
        {
            employed = value;
        }
    }

    public float Money
    {
        get
        {
            return money;
        }
        set
        {
            money = value;
        }
    }

    public float Debt
    {
        get
        {
            return debt;
        }
        set
        {
            debt = value; 
        }
    }

    public uint Time
    {
        get
        {
            return time;
        }
        set
        {
            time = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
