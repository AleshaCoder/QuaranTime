using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadWash2 : MonoBehaviour
{
    public void Reloading()
    {
        TimerWashing.NumTime = 20;
        BarMover.IsEnd = false;
        if (BarMover.GorB)
        {
            GameTimer.GigienaValue += 0.3f;
            GameTimer.EnergyValue -= 0.05f;
        }
        else
        {
            GameTimer.HealthValue -= 0.1f;
        }
        Soup.Amount -= 1;
        GameTimer.Sec -= 10;
        SaveLoad.SaveParametrs();
        SaveLoad.SavePlayerStats();
        BarMover.GorB = false;
    }
}
