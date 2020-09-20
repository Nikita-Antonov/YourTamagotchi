using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamagotchiLogic : MonoBehaviour
{
    EnumClass enumClass;

    public string petName;

    public int petAge;

    public int maxHealthValue;
    public int curHealthValue;

    public int maxHungerValue;          //Hunger/food
    public int curHungerValue;
    public int overflowHungerValue;

    public int maxMoodValue;            //Happieness
    public int curMoodValue;

    public int maxWeightValue;          //Weight
    public int curWeightValue;

    /*
     * How this would work is that the the food, happiness and weight values all get avraged and outputed to a health value
     * The age of the pet will act as a "weight" or "bias" if you can call it that, of the health value, making it go lower as 
     * the pet gets older. Same thing will happen with the overflow hunger value, where if you feed him too much, he will gain
     * to much weight and/or he will suffer a health penely
     */

    


    void Start()
    {
        curHealthValue = maxHealthValue;
        curHungerValue = maxHealthValue;
        curMoodValue = maxMoodValue;
        curWeightValue = maxWeightValue;
    }

    void HealthCalculator()
    {
        curHealthValue = ((curHealthValue + curHungerValue + curMoodValue) / 3) - (petAge / 15);        //Takes the Avrage of the 3 main values and the avrage of the pets age in order to determine the overall health of the pet
    }

    void SetHealth()
    {

    }

    void SetHunger()
    {

    }

    void SetMood()
    {

    }

    void SetWeight()
    {

    }
}
