using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    #region Fields
    public GameObject Hero;
    public Text Health, Happy, Gigiena, Energy, Havka;
    public Text DayTime, AllTime;
    public GameObject PanelDead;
    public static float HealthValue, HappyValue, GigienaValue, EnergyValue, HavkaValue;
    public static bool MainSceneIsActive = true;
    public static bool LoadStats = false;
    public static bool HeroDead = false;
    public static int Min=5, Sec=0, Day=60, Hardness;
    #endregion

    void Start()
    {
        if (PlayerPrefs.HasKey("Hardness"))
            Hardness = PlayerPrefs.GetInt("Hardness");
        else
            Hardness = 2;
        if (LoadStats)
        {
            SaveLoad.LoadPlayerStats();
            SaveLoad.LoadParametrs();
            if (PlayerPrefs.HasKey("PosX"))
                LoadPlayerPosition();
        }
        else
        {
            Sec = 0;
            Min = 5;
            HealthValue = 0.9f;
            HappyValue = 0.7f;
            GigienaValue = 0.85f;
            HavkaValue = 0.65f;
            EnergyValue = 0.7f;
            Money.Amount = 2000 / Hardness;
            Apple.Amount = 10 / Hardness;
            Milk.Amount = 1;
            Chicken.Amount = 1;
            Pasta.Amount = 1;
            Soup.Amount = 5;
            Paper.Amount = 10;
            Mask.Amount = 10;
            SaveLoad.SaveParametrs();
            SaveLoad.SavePlayerStats();
            SavePlayerPosition();
            LoadStats = true;
        }
        StartCoroutine(DateTimer());
    }

    private void TimeChanged()
    {
        if (Day<0)
        {
            PlayerPrefs.DeleteAll();
            PanelDead.SetActive(true);
        }
        AllTime.text = Day.ToString();
        if (Sec <= 0)
        {
            if (Min == 0)
            {
                Min = 5;
                Day -= 1;
                AllTime.text = Day.ToString();
            }
            Min -= 1;
            Sec = 60;
        }
        Sec -= 1;
        if (Sec < 10)
        {
            DayTime.text = Min.ToString() + ":0" + Sec.ToString();
        }
        else
        {
            DayTime.text = Min.ToString() + ":" + Sec.ToString();
        }
    }

    public void SavePlayerPosition()
    {
        PlayerPrefs.SetFloat("PosX", Hero.transform.position.x);
        PlayerPrefs.SetFloat("PosY", Hero.transform.position.y);
        PlayerPrefs.SetFloat("PosZ", 90);
        PlayerPrefs.SetFloat("RotX", Hero.transform.rotation.x);
        PlayerPrefs.SetFloat("RotY", Hero.transform.rotation.y);
        PlayerPrefs.SetFloat("RotZ", Hero.transform.rotation.z);
        PlayerPrefs.SetFloat("RotW", Hero.transform.rotation.w);
    }

    public void LoadPlayerPosition()
    {
        Hero.transform.position = new Vector3(PlayerPrefs.GetFloat("PosX"), PlayerPrefs.GetFloat("PosY"), PlayerPrefs.GetFloat("PosZ"));
        Hero.transform.rotation = new Quaternion(PlayerPrefs.GetFloat("RotX"), PlayerPrefs.GetFloat("RotY"), PlayerPrefs.GetFloat("RotZ"), PlayerPrefs.GetFloat("RotW"));
    }

    private void StatChanged()
    {
        HappyValue -= 0.0011f * Hardness / 2;
        GigienaValue -= 0.002f * Hardness / 2;
        EnergyValue -= 0.0034f * Hardness / 2;
        HavkaValue -= 0.0025f * Hardness / 2;
        Health.text = HealthValue.ToString("0%");
        Happy.text = HappyValue.ToString("0%");
        Gigiena.text = GigienaValue.ToString("0%");
        Energy.text = EnergyValue.ToString("0%");
        Havka.text = HavkaValue.ToString("0%");
        SaveLoad.SaveParametrs();
        SaveLoad.SavePlayerStats();
        if ((HappyValue < 0.1f) || (GigienaValue < 0.15f) || (EnergyValue < 0.15f) || (HavkaValue < 0.2f))
        {
            if (LoadStats)
            {
                 HealthValue -= 0.01f;
            }        
        }
        if ((HappyValue <0) || (GigienaValue < 0) || (EnergyValue < 0) || (HavkaValue < 0))
        {
            if (LoadStats)
            {
            PlayerPrefs.DeleteAll();
            PanelDead.SetActive(true);
            LoadStats = false;
            Debug.Log("Ты лошпед");
                PlayerPrefs.SetFloat("PosX", 0);
                PlayerPrefs.SetFloat("PosY", 0);
                PlayerPrefs.SetFloat("PosZ", 90);
                PlayerPrefs.SetFloat("RotX", 0);
                PlayerPrefs.SetFloat("RotY", 0);
                PlayerPrefs.SetFloat("RotZ", 0);
                PlayerPrefs.SetFloat("RotW", 0);
            }
        }

        if (HealthValue < 0.1f)
        {
            if (LoadStats)
            { 
            var shans = Random.Range(0.01f, HealthValue);
                if (shans < 0.03)
                {
                    PlayerPrefs.DeleteAll();
                    PanelDead.SetActive(true);
                    LoadStats = false;
                    Debug.Log("Ты лошпед");
                    PlayerPrefs.SetFloat("PosX", 0);
                    PlayerPrefs.SetFloat("PosY", 0);
                    PlayerPrefs.SetFloat("PosZ", 90);
                    PlayerPrefs.SetFloat("RotX", 0);
                    PlayerPrefs.SetFloat("RotY", 0);
                    PlayerPrefs.SetFloat("RotZ", 0);
                    PlayerPrefs.SetFloat("RotW", 0);
                }
            }
        }
    }

    IEnumerator DateTimer()
    {
        while (!HeroDead)
        {
            if (MainSceneIsActive)
            {
                TimeChanged();
                StatChanged();
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
