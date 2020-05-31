using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SonManager : MonoBehaviour
{
    public GameObject Player;
    public Image Blank;
    private int Transp = 0;
    private int q = 1;
public void Son()
    {
        Player.SetActive(false);
        Blank.gameObject.SetActive(true);
        Blank.color = new Color32(0, 0, 0, 0);
        StartCoroutine(SonTimer());
        GameTimer.HavkaValue -= 0.0025f * 75;
        GameTimer.EnergyValue = 1f;
        if (GameTimer.Min >= 1)
        {
            GameTimer.Min -= 1;
        }
        else
        {
            GameTimer.Min = 4;
            GameTimer.Day -= 1;
        }
        
        if (GameTimer.Sec>=25)
        {
            GameTimer.Sec -= 25;
        }
        else
        {
            GameTimer.Sec = 60-25;
        }
    }
    IEnumerator SonTimer()
    {
        while (Transp>=0)
        {
            if ((Transp==0)&&(q==-1))
            {
                Blank.gameObject.SetActive(false);
                Player.SetActive(true);
                q = 1;
                break;
            }
            Transp += q;
            Blank.color = new Color32(0, 0, 0, (byte) Transp);
            if (Transp==255)
            {
                q = -1;
            }
            yield return new WaitForSeconds(0.001f);
        }
    }
}
