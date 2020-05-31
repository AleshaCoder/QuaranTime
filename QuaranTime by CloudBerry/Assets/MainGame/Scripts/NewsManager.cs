using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class StrArray
{
    public string[] str0Array = new string[3];
    public int[] Yes = new int[6];
    public int[] No = new int[6];
}
public class NewsManager : MonoBehaviour
{
    public GameObject Panel;
    public Text[] bloks;
    public Text Answer, Sol1, Sol2,q1,q2,q3,q4,q5,q6;
    public Button YesButton, NoButton, OkButton;
    public StrArray[] strArray = new StrArray[3];
    private int NumAnswer,  TimeMin;
    private byte RandTime;
    private static bool Soluting=false;
    public void SelectedYes()
    {
        for (int i = 0; i <= bloks.Length - 1; i++)
        {
            bloks[i].gameObject.SetActive(true);
        }
        Answer.text = strArray[PlayerPrefs.GetInt("NumAnswer")].str0Array[1];
        YesButton.gameObject.SetActive(false);
        NoButton.gameObject.SetActive(false);
        OkButton.gameObject.SetActive(true);
        q1.text = strArray[PlayerPrefs.GetInt("NumAnswer")].Yes[0].ToString();
        q2.text = strArray[PlayerPrefs.GetInt("NumAnswer")].Yes[1].ToString();
        q3.text = strArray[PlayerPrefs.GetInt("NumAnswer")].Yes[2].ToString();
        q4.text = strArray[PlayerPrefs.GetInt("NumAnswer")].Yes[3].ToString();
        q5.text = strArray[PlayerPrefs.GetInt("NumAnswer")].Yes[4].ToString();
        q6.text = strArray[PlayerPrefs.GetInt("NumAnswer")].Yes[5].ToString();
        GameTimer.HealthValue += strArray[PlayerPrefs.GetInt("NumAnswer")].Yes[0] / 100.0f;
        GameTimer.HappyValue += strArray[PlayerPrefs.GetInt("NumAnswer")].Yes[1] / 100.0f;
        GameTimer.GigienaValue += strArray[PlayerPrefs.GetInt("NumAnswer")].Yes[2] / 100.0f;
        GameTimer.EnergyValue += strArray[PlayerPrefs.GetInt("NumAnswer")].Yes[3] / 100.0f;
        GameTimer.HavkaValue += strArray[PlayerPrefs.GetInt("NumAnswer")].Yes[4] / 100.0f;
        GameTimer.Min += strArray[PlayerPrefs.GetInt("NumAnswer")].Yes[5];
        if (GameTimer.Min<=0)
        {
            GameTimer.Min = 4;
            GameTimer.Sec = 60;
            GameTimer.Day -= 1;            
        }
        SaveLoad.SavePlayerStats();
    }
    public void SelectedNo()
    {
        for (int i = 0; i <= bloks.Length - 1; i++)
        {
            bloks[i].gameObject.SetActive(true);
        }
        Answer.text = strArray[PlayerPrefs.GetInt("NumAnswer")].str0Array[2];
        YesButton.gameObject.SetActive(false);
        NoButton.gameObject.SetActive(false);
        OkButton.gameObject.SetActive(true);
        q1.text = strArray[PlayerPrefs.GetInt("NumAnswer")].No[0].ToString();
        q2.text = strArray[PlayerPrefs.GetInt("NumAnswer")].No[1].ToString();
        q3.text = strArray[PlayerPrefs.GetInt("NumAnswer")].No[2].ToString();
        q4.text = strArray[PlayerPrefs.GetInt("NumAnswer")].No[3].ToString();
        q5.text = strArray[PlayerPrefs.GetInt("NumAnswer")].No[4].ToString();
        q6.text = strArray[PlayerPrefs.GetInt("NumAnswer")].No[5].ToString();
        GameTimer.HealthValue += strArray[PlayerPrefs.GetInt("NumAnswer")].No[0] / 100.0f;
        GameTimer.HappyValue += strArray[PlayerPrefs.GetInt("NumAnswer")].No[1] / 100.0f;
        GameTimer.GigienaValue += strArray[PlayerPrefs.GetInt("NumAnswer")].No[2] / 100.0f;
        GameTimer.EnergyValue += strArray[PlayerPrefs.GetInt("NumAnswer")].No[3] / 100.0f;
        GameTimer.HavkaValue += strArray[PlayerPrefs.GetInt("NumAnswer")].No[4] / 100.0f;
        GameTimer.Min += strArray[PlayerPrefs.GetInt("NumAnswer")].No[5];
        if (GameTimer.Min <=0)
        {
            GameTimer.Min += 4;
            GameTimer.Sec = 60;
            GameTimer.Day -= 1;

        }
        SaveLoad.SavePlayerStats();
    }
    public void SelectedOK()
    {
        for (int i = 0; i <= bloks.Length - 1; i++)
        {
            bloks[i].gameObject.SetActive(false);
        }
        YesButton.gameObject.SetActive(true);
        NoButton.gameObject.SetActive(true);
        OkButton.gameObject.SetActive(false);
        q1.text = "";
        q2.text = "";
        q3.text = "";
        q4.text = "";
        q5.text = "";
        q6.text = "";
        Panel.SetActive(false);
        NumAnswer = Random.Range(0, 24);
        PlayerPrefs.SetInt("NumAnswer", NumAnswer);
        Soluting = false;
    }
    public void Reloading()
    {
        
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("RandTime"))
        {
            RandTime = (byte)PlayerPrefs.GetInt("RandTime");
            PlayerPrefs.GetInt("NumAnswer");
        }
        else
        {
            NumAnswer = Random.Range(0, 24);
            PlayerPrefs.SetInt("NumAnswer", NumAnswer);
            RandTime = (byte)Random.Range(20, 200);
        }
        StartCoroutine(TimerNews());
    }

    IEnumerator TimerNews()
    {
        while (true)
        {
            RandTime -= 10;
            if (RandTime==0)
            {
                if (!Soluting)
                {
                    Panel.SetActive(true);
                    Answer.text = strArray[PlayerPrefs.GetInt("NumAnswer")].str0Array[0];
                    Soluting = true;
                    RandTime = (byte)(Random.Range(2, 20)*10);
                }
            }
            PlayerPrefs.SetInt("RandTime",RandTime);
            yield return new WaitForSeconds(10);
        }
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("RandTime");
    }
}
