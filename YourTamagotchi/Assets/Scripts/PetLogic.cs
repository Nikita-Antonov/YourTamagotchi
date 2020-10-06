using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

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
    [Space]

    [Header("Secondary Pet Values")]
    [SerializeField] private int biasValue;
    [SerializeField] private int overweightValue;       //Overflow Weight Value
    [SerializeField] private int annoyedValue;          //Overflow Happyness Value
    [SerializeField] private int maxAnnoyedValue = 5;   //Max Overflow Happyness Value

    private void FixedUpdate()
    {
        HeartBeat();
    }

    void HeartBeat()
    {
        float curTick = 0;
        float maxTick = 10;

        if (curTick < 0)
            curTick -= Time.deltaTime;
        if (curTick <= 0)
        {
            Logic();

            curTick = maxTick;

        }
    }

    void Logic()
    {
        Happyness();
        Food();
        Weight();

        HealthCalculator();
    }

    void HealthCalculator()
    {
        curHealth = ((curWeight + curHappiness + curFood) / 3) - ((curAge - maxAge) / maxAge);
    }

    //---------------- Happyness ------------------

    void Happyness()
    {
        if (curHappiness < 0)
            curHappiness = 0;
        if (curHappiness == 0)
            curHealth--;
        if (curHappiness > maxValue)
            curHappiness = maxValue;
        if (curHappiness == maxValue)
            annoyedValue++;


        //If the pet becomes annoyed it will become less happy

        if (annoyedValue > maxAnnoyedValue)
            annoyedValue = maxAnnoyedValue;
        if (annoyedValue > 0)
            curHappiness -= annoyedValue;
    }

    //Action
    public void PlayWithPet()
    {
        curHappiness += 2;
    }

    //---------------- Food ------------------

    void Food()
    {
        if (curFood < 0)
            curFood = 0;
        if (curFood == 0)
            curWeight --;
        if (curFood > 0 && curFood <= 3)
            curHealth --;
        //values over 3 and below 7 are normal, as such have no effect
        if (curFood > 7 && curFood < maxValue)
            curHealth --;
        if (curFood > maxValue)
            curFood = maxValue;
        if (curFood == maxValue)
        {
            curWeight ++;
            curHappiness --;
        }
    }

    //Action
    public void FeedPet()
    {
        curFood += 2;
    }

    //---------------- Weight ------------------

    void Weight()
    {

    }

}