using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadWash : MonoBehaviour
{
  public void Reloading()
    {
        WashTimer.Fill = 1;
        GameTimer.GigienaValue += GameProcess.NumClicks / 5.0f;
        Debug.Log(GameProcess.NumClicks / 5.0f);
        GameTimer.EnergyValue -= 0.05f;
        Soup.Amount -= 1;
        GameProcess.NumClicks = 0;
        SaveLoad.SaveParametrs();
        SaveLoad.SavePlayerStats();
    }
}
