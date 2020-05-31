using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadShop : MonoBehaviour
{
public void Reloading()
    {
        SpawnVirus.Time = 20;
        FallDown.MagOrDom = true;
        SaveLoad.SavePlayerStats();
        SaveLoad.SaveParametrs();
    }
}
