using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetLogic : MonoBehaviour
{
    /*
     * The "maxValue" Variable is a permenant variable that is the maximum point for all main variables, except for age
     * Instead of creating a max variable for each of the variables, one is used to save on space both in memory and in 
     * the code editor, also makes the code a little better to look at.
    */
    [Header("Constant Max Value")]
    [SerializeField] private const int maxValue = 10;
    [Space]

    //Pet Age Variables
    [Header("Age Values")]
    [SerializeField] private int maxAge = 15;
    [SerializeField] private int curAge;
    [Space]

    //The 4 main variables
    [Header("Main Pet Values")]
    [SerializeField] private int curWeight;
    [SerializeField] private int curHappiness;
    [SerializeField] private int curFood;

    [SerializeField] private int curHealth;

    private void Start()
    {
        curWeight = curHappiness = curFood = maxValue;
        curAge = 1;
    }

    private void FixedUpdate()
    {
        HealthCalculator();
    }

    /*
     * This function takes the Weight, Happiness and Food values,
     * avrages them and takes the age of the pet as a "Bias" to the
     * overall health of the Pet.
     * (The older the pet, the more of a health penelty it will sufferr)
     */
    void HealthCalculator()
    {
        curHealth = ((curWeight + curHappiness + curFood) / 3) - curAge / maxAge;

        Debug.Log(curHealth);
    }

    //Function for UI Button to feed the pet
    public void FeedPet()
    {

    }

    //Function for UI Button to play with the pet
    public void PlayWithPet()
    {

    }

}