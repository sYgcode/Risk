using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Security.Cryptography.X509Certificates;

public class ContryInfo : MonoBehaviour
{
    // lists to divide the gameobjects to choose who owns them
    public static List<GameObject> myCountries = new List<GameObject>();
    public static List<GameObject> AICountries = new List<GameObject>();

    // array of game objects(the countries) that are in the game which i added in the inspector (as of now there are 5)
    public GameObject[] Countries;

    void Awake()
    {
        // a foreach loop that is meant to go through each country in the array and assign it randomly
        foreach (GameObject Country in Countries)
        {
            int whos = UnityEngine.Random.Range(1, 3);
            if (myCountries.Count >= 3)
                AICountries.Add(Country);
            else if (AICountries.Count >= 2)
                myCountries.Add(Country);
            else
                if (whos == 1)
                    myCountries.Add(Country);
                
                else if (whos == 2)
                    AICountries.Add(Country);
            return;
        }
    }

}