using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadShop2 : MonoBehaviour
{
    public void Reloading()
    {
        if (Mask.Amount>0)
        {
            GameTimer.GigienaValue -= Player.lose * 0.1f;
            Mask.Amount -= 1;
        }
        else
        {
            GameTimer.GigienaValue -= Player.lose * 0.2f;
        }
        if (Antiseptic.Amount>0)
        {
            GameTimer.GigienaValue += Player.lose * 0.05f;
            Antiseptic.Amount -= 1;
        }
        GameTimer.HavkaValue -=  0.1f;
        GameTimer.HappyValue +=  0.1f;
        GameTimer.EnergyValue -=  0.1f;
        GameTimer.Sec -= 10;
        Player.lose = 0;
        SpawnVirus.Time = 20;
        FallDown.MagOrDom = false;
        SaveLoad.SavePlayerStats();
        SaveLoad.SaveParametrs();
    }
}
