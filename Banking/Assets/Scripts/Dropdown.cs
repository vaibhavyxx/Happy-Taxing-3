using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dropdown : MonoBehaviour
{
    // fields
    [SerializeField] private TextMeshProUGUI text;

    [SerializeField] GameObject dropDownPanel;
    [SerializeField] Button myButton;

    private bool isClicked = true;

    // Start is called before the first frame update
    void Start()
    {
        dropDownPanel.SetActive(false);

        myButton.GetComponent<Button>();

        myButton.onClick.AddListener(ShowDropDown);
    }
    void Update()
    {
        /*text.text = "Time: " + Player.Instance.Time + ":00" +
                    "\nTaxes: " + Player.Instance.Tax +
                        "\n SSN: " + Player.Instance.SSNtax +
                        "\n Medicare: " + Player.Instance.MedicareTax;*/
    }

    public void ShowDropDown()
    {
        isClicked = !isClicked;
        //Debug.Log(isClicked);
        dropDownPanel.SetActive(isClicked);
    }

}
