using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class TimeBar2 : MonoBehaviour
{
    public Image Bar;
    public Text Score, ScoreText;
    public GameObject Panel;
    public static float Fill = 1f;

    private void Start()
    {
        StartCoroutine("TimerX");
    }


    IEnumerator TimerX()
    {
        while (Fill>0)
        {
            Fill -= 0.05f;
            Bar.fillAmount = Fill;
            Score.text = Bug.Score.ToString();
            if (Fill<=0)
            {
                Panel.SetActive(true);
                ScoreText.text = (Bug.Score * 20).ToString() + "P";
                Money.Amount += Bug.Score * 20;
                GameTimer.EnergyValue -= 0.2f;
                GameTimer.HavkaValue -= 0.1f;
                GameTimer.HappyValue += 0.1f;
                GameTimer.Min -= 1;
                SaveLoad.SaveParametrs();
                SaveLoad.SavePlayerStats();
                break;
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
