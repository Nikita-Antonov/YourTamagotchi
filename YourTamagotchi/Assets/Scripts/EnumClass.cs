using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumClass : MonoBehaviour
{
    public enum Health      //Health Types
    {
        Amazing,
        Good,
        Ok,
        Bad,
        Terrible,
        Dead
    }

    public enum Weight      //Weight Types
    {
        Underweight,
        Skinny,
        Normal,
        SlightlyObease,
        Obease
    }

    public enum Mood        //Mood Types
    {
        Happy,
        Nutral,
        Sad,
        Depresed,
        Extatic,
        Suicidal
    }

    public enum Hunger      //Hunger Types
    {
        Malnurished,
        Hungry,
        NotHungry,
        OverAte
    }

}
