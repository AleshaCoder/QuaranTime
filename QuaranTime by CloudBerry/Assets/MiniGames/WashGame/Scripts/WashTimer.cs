using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WashTimer : MonoBehaviour
{
    public Image Bar;
    public Text TimeText,TextScore;
    public GameObject Panel;
    public static float Fill = 1f;
    private float MTime;
    public void Start()
    {
        MTime = Random.Range(0.05f, 0.09f);
        TimeText.text = (Fill / MTime).ToString("0");
    }
    private void FixedUpdate()
    {
        StartCoroutine("TimeReduce");
    }

    IEnumerator TimeReduce()
    {
        if (Fill>0)
        {
            Fill -= Time.fixedDeltaTime * MTime;
            Bar.fillAmount = Fill;
            TimeText.text = (Fill / MTime).ToString("0");   
        }
        else
        {
            Panel.SetActive(true);
            TextScore.text = (Mathf.CeilToInt(GameProcess.NumClicks * 100 / 5)).ToString("0");
        }
        yield return null;
    }
}
