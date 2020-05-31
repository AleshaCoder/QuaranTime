using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public  GameObject Player;

    public static void SaveParametrs()
    {
        PlayerPrefs.SetInt("Limon", Limon.Amount);
        PlayerPrefs.SetInt("Apple", Apple.Amount);
        PlayerPrefs.SetInt("Onion", Onion.Amount);
        PlayerPrefs.SetInt("Potato", Potato.Amount);
        PlayerPrefs.SetInt("Cheese", Cheese.Amount);
        PlayerPrefs.SetInt("Milk", Milk.Amount);
        PlayerPrefs.SetInt("Yoghurt", Yoghurt.Amount);
        PlayerPrefs.SetInt("IceCream", IceCream.Amount);
        PlayerPrefs.SetInt("Beef", Beef.Amount);
        PlayerPrefs.SetInt("Chicken", Chicken.Amount);
        PlayerPrefs.SetInt("Cutlet", Cutlet.Amount);
        PlayerPrefs.SetInt("Pasta", Pasta.Amount);
        PlayerPrefs.SetInt("Rise", Rise.Amount);
        PlayerPrefs.SetInt("Nuddles", Nuddles.Amount);
        PlayerPrefs.SetInt("Buckwheat", Buckwheat.Amount);
        PlayerPrefs.SetInt("Soup", Soup.Amount);
        PlayerPrefs.SetInt("Paper", Paper.Amount);
        PlayerPrefs.SetInt("Antiseptic", Antiseptic.Amount);
        PlayerPrefs.SetInt("Mask", Mask.Amount);
        PlayerPrefs.SetInt("Vits", Vits.Amount);
        PlayerPrefs.SetInt("Antibiotics", Antibiotics.Amount);
        PlayerPrefs.SetInt("Money", Money.Amount);
        PlayerPrefs.Save();
    }

    public static void SavePlayerStats()
    {
        PlayerPrefs.SetFloat("Health", GameTimer.HealthValue);
        PlayerPrefs.SetFloat("Happy", GameTimer.HappyValue);
        PlayerPrefs.SetFloat("Havka", GameTimer.HavkaValue);
        PlayerPrefs.SetFloat("Energy", GameTimer.EnergyValue);
        PlayerPrefs.SetFloat("Gigiena", GameTimer.GigienaValue);
        PlayerPrefs.SetInt("Day", GameTimer.Day);
        PlayerPrefs.SetInt("Sec", GameTimer.Sec);
        PlayerPrefs.SetInt("Min", GameTimer.Min);
    }

    public static void LoadPlayerStats()
    {
        GameTimer.HealthValue=PlayerPrefs.GetFloat("Health");
        GameTimer.HappyValue = PlayerPrefs.GetFloat("Happy");
        GameTimer.HavkaValue = PlayerPrefs.GetFloat("Havka");
        GameTimer.EnergyValue = PlayerPrefs.GetFloat("Energy");
        GameTimer.GigienaValue = PlayerPrefs.GetFloat("Gigiena");
        GameTimer.Day = PlayerPrefs.GetInt("Day");
        GameTimer.Sec = PlayerPrefs.GetInt("Sec");
        GameTimer.Min = PlayerPrefs.GetInt("Min");
    }

    public static void LoadParametrs()
    {
        Limon.Amount=PlayerPrefs.GetInt("Limon");
        Apple.Amount=PlayerPrefs.GetInt("Apple");
        Onion.Amount=PlayerPrefs.GetInt("Onion");
        Potato.Amount=PlayerPrefs.GetInt("Potato");
        Cheese.Amount=PlayerPrefs.GetInt("Cheese");
        Milk.Amount=PlayerPrefs.GetInt("Milk");
        Yoghurt.Amount=PlayerPrefs.GetInt("Yoghurt");
        IceCream.Amount=PlayerPrefs.GetInt("IceCream");
        Beef.Amount=PlayerPrefs.GetInt("Beef");
        Chicken.Amount=PlayerPrefs.GetInt("Chicken");
        Cutlet.Amount=PlayerPrefs.GetInt("Cutlet");
        Pasta.Amount=PlayerPrefs.GetInt("Pasta");
        Rise.Amount=PlayerPrefs.GetInt("Rise");
        Nuddles.Amount=PlayerPrefs.GetInt("Nuddles");
        Buckwheat.Amount=PlayerPrefs.GetInt("Buckwheat");
        Soup.Amount=PlayerPrefs.GetInt("Soup");
        Paper.Amount=PlayerPrefs.GetInt("Paper");
        Antiseptic.Amount=PlayerPrefs.GetInt("Antiseptic");
        Mask.Amount=PlayerPrefs.GetInt("Mask");
        Vits.Amount=PlayerPrefs.GetInt("Vits");
        Antibiotics.Amount=PlayerPrefs.GetInt("Antibiotics");
        Money.Amount=PlayerPrefs.GetInt("Money");
    }
}
