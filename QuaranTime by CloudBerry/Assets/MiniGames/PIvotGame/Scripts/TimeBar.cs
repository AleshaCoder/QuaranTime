using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TimeBar : MonoBehaviour
{
    public Image Bar;
    public GameObject Panel;
    public static bool q1 = false;
    public Text Time, Scoretext,ScoreText2,MoneyText;
    public static float Fill = 1f;
    public void Restart()
    {

    }
    private void Start()
    {
        StartCoroutine(PivotTimer());
        StartCoroutine(ScoreTimer());
    }
    IEnumerator ScoreTimer()
    {
        while (true)
        {
            Scoretext.text = HitCheck.Score.ToString();
            ScoreText2.text = Scoretext.text;
            MoneyText.text = (HitCheck.Score * 10).ToString();
            yield return new WaitForSeconds(0.05f);
        }
    }
    IEnumerator PivotTimer()
    {
        while (true)
        {
            if (Fill>0)
            {
                Fill -= 0.05f;
                Time.text = (Fill/0.05f).ToString("0");
                Bar.fillAmount = Fill;
            }
            else
            {
                if (!q1)
                {
                    Panel.SetActive(true);
                    Money.Amount += HitCheck.Score * 10;
                    GameTimer.EnergyValue -= 0.2f;
                    GameTimer.HavkaValue -= 0.05f;
                    GameTimer.HappyValue += 0.05f;
                    GameTimer.Min -= 1;
                    SaveLoad.SaveParametrs();
                    SaveLoad.SavePlayerStats();
                    q1 = true;
                }
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
