using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public static bool IsContinue;

    public void NewGame()
    {
        IsContinue = false;
        GameTimer.Sec = 0;
        GameTimer.Min = 5;
        GameTimer.Day = 60;
        GameTimer.HealthValue = 1;
        GameTimer.HappyValue = 1;
        GameTimer.GigienaValue = 1;
        GameTimer.HavkaValue = 1;
        GameTimer.EnergyValue = 1;
        Money.Amount = 1000;
        SaveLoad.SavePlayerStats();
        Apple.Amount = 5;
        Milk.Amount = 1;
        Chicken.Amount = 1;
        Pasta.Amount = 1;
        Soup.Amount = 5;
        Paper.Amount = 10;
        Mask.Amount = 10;
        PlayerPrefs.SetFloat("PosX", 0);
        PlayerPrefs.SetFloat("PosY", 0);
        PlayerPrefs.SetFloat("PosZ", 90);
        PlayerPrefs.SetFloat("RotX", 0);
        PlayerPrefs.SetFloat("RotY", 0);
        PlayerPrefs.SetFloat("RotZ", 0);
        PlayerPrefs.SetFloat("RotW", 0);
        SaveLoad.SaveParametrs();
        SaveLoad.SavePlayerStats();
        GameTimer.LoadStats = true;
    }

    public void Continue()
    {
        IsContinue = true;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
