using System.Collections;
using System.Collections.Generic;
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

    [Header("Slider Bar Reffrences")]
    public Slider ageSlider;
    public Slider weightSlider;
    public Slider happinessSlider;
    public Slider foodSlider;
    public Slider healthSliderl;
    [Space]

    [Header("Button Reffrences")]
    public Button feedPet;
    public Button playWithPet;
    

    private void Start()
    {
        curWeight = curHappiness = curFood = maxValue;
        curAge = 1;

        //Setting all the max values of the sliders, since I am ussing whole numbers instead of floats, the numbers need to be bigger than 1
        //Also if i wish to change the max value then they will all update
        ageSlider.maxValue = maxValue;
        weightSlider.maxValue = maxValue;
        happinessSlider.maxValue = maxValue;
        foodSlider.maxValue = maxValue;
        healthSliderl.maxValue = maxValue;

        weightSlider.value = curWeight;
        happinessSlider.value = curHappiness;
        foodSlider.value = curFood;
        healthSliderl.value = maxValue;
    }

    private void FixedUpdate()
    {
        HealthCalculator();
    }

    void TickTimer()
    {
        float curTime = 10;
        float maxTime = 10;

        if (curTime > 0)
            curTime -= Time.deltaTime;
        if (curTime < 0)
            curTime = 0;
        if(curTime == 0)
        {
            HealthCalculator();

            ageSlider.value = curAge;
            weightSlider.value = curWeight;
            happinessSlider.value = curHappiness;
            foodSlider.value = curFood;
            healthSliderl.value = maxValue;

            curTime = maxTime;
        }
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
        int petFood = 4;
        curFood += petFood;
    }

    //Function for UI Button to play with the pet
    public void PlayWithPet()
    {
        int happyPlay = 10;
        curHappiness += happyPlay;
    }

}