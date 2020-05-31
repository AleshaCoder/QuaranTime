using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadFolder : MonoBehaviour
{
   public void Reloading()
    {
        Score.score = 0;
        GameTimer.EnergyValue -= 0.1f;
        GameTimer.HappyValue += 0.02f;
        GameTimer.HavkaValue -= 0.05f;
        GameTimer.Min -= 1;
        Money.Amount += 100;
        SaveLoad.SaveParametrs();
        SaveLoad.SavePlayerStats();
    }
}
