using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountryClick : MonoBehaviour
{
    // meant to pop up when country is clicked on
    public GameObject countryInfoCard;

    // i havent implemented yet
    public TextMeshProUGUI CountryName;
    public TextMeshProUGUI IsMyCountry;

    // on click function
    public void Country1Clicked()
    {
        // if the GameObject 'Country1' is part of the 'myCountries' list then it is meant to change the IsMyCountry text to this
        //but i get an alert in the console saying "\CountryClick.cs(19,45): error CS0103: The name 'Country1' does not exist in the current context"
        if (ContryInfo.myCountries.Contains(Country1))
        {
            IsMyCountry.text = "Owned By: Me";
            IsMyCountry.color = Color.green;
        }
        else
        {
            IsMyCountry.text = "Owned By: AI";
            IsMyCountry.color = Color.red;
        }

        countryInfoCard.SetActive(!countryInfoCard.activeSelf);
    }

}
