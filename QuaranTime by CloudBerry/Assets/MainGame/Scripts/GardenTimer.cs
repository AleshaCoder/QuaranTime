using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GardenTimer : MonoBehaviour
{
    #region Fields
    public GameObject Hero;
    public Text Health, Happy, Gigiena, Energy, Havka;
    public Text DayTime, AllTime;
    public GameObject PanelDead;
    public static bool MainSceneIsActive = true;
    public static bool LoadStats = false;
    public static bool HeroDead = false;
    #endregion

    void Start()
    {
        LoadPlayerPosition();
        StartCoroutine(DateTimer());
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

    private void TimeChanged()
    {
        if (GameTimer.Day < 0)
        {
            PlayerPrefs.DeleteAll();
            PanelDead.SetActive(true);
        }
        AllTime.text = GameTimer.Day.ToString();
        if (GameTimer.Sec == 0)
        {
            if (GameTimer.Min == 0)
            {
                GameTimer.Min = 5;
                GameTimer.Day -= 1;
                AllTime.text = GameTimer.Day.ToString();
            }
            GameTimer.Min -= 1;
            GameTimer.Sec = 60;
        }
        GameTimer.Sec -= 1;
        if (GameTimer.Sec < 10)
        {
            DayTime.text = GameTimer.Min.ToString() + ":0" + GameTimer.Sec.ToString();
        }
        else
        {
            DayTime.text = GameTimer.Min.ToString() + ":" + GameTimer.Sec.ToString();
        }
    }

    private void StatChanged()
    {
        GameTimer.HappyValue -= 0.0011f * GameTimer.Hardness / 4;
        GameTimer.GigienaValue -= 0.002f * GameTimer.Hardness;
        GameTimer.EnergyValue -= 0.0034f * GameTimer.Hardness / 2;
        GameTimer.HavkaValue -= 0.0025f * GameTimer.Hardness / 2;
        Health.text = GameTimer.HealthValue.ToString("0%");
        Happy.text = GameTimer.HappyValue.ToString("0%");
        Gigiena.text = GameTimer.GigienaValue.ToString("0%");
        Energy.text = GameTimer.EnergyValue.ToString("0%");
        Havka.text = GameTimer.HavkaValue.ToString("0%");
        if ((GameTimer.HappyValue < 0.1f) || (GameTimer.GigienaValue < 0.15f) || (GameTimer.EnergyValue < 0.15f) || (GameTimer.HavkaValue < 0.2f))
        {
                GameTimer.HealthValue -= 0.01f;
        }
        if ((GameTimer.HappyValue < 0) || (GameTimer.GigienaValue < 0) || (GameTimer.EnergyValue < 0) || (GameTimer.HavkaValue < 0))
        {
                PlayerPrefs.DeleteAll();
                PanelDead.SetActive(true);
                LoadStats = false;
            PlayerPrefs.SetFloat("PosX", 0);
            PlayerPrefs.SetFloat("PosY", 0);
            PlayerPrefs.SetFloat("PosZ", 90);
            PlayerPrefs.SetFloat("RotX", 0);
            PlayerPrefs.SetFloat("RotY", 0);
            PlayerPrefs.SetFloat("RotZ", 0);
            PlayerPrefs.SetFloat("RotW", 0);
        }

        if (GameTimer.HealthValue < 0.1f)
        {
            if (LoadStats)
            {
                var shans = Random.Range(0.01f, GameTimer.HealthValue);
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
