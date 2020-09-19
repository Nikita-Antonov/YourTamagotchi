using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamagotchiLogic : MonoBehaviour
{
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
    public int cueWeightValue;

    /*
     * How this would work is that the the food, happiness and weight values all get avraged and outputed to a health value
     * The age of the pet will act as a "weight" or "bias" if you can call it that, of the health value, making it go lower as 
     * the pet gets older. Same thing will happen with the overflow hunger value, where if you feed him too much, he will gain
     * to much weight and/or he will suffer a health penely
     */
}
