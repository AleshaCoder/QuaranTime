using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarMover : MonoBehaviour
{
    public GameObject Panel, Panel2;
    public GameObject Bubbles;
    public Button ColdButton, HotButton;
    public Transform MovedBar;
    private static float speed;
    private bool DoubleClickCold, DoubleClickHot;
    public static bool IsEnd=false, GorB=false;

    private void IsLongDistance()
    {
        if ((MovedBar.position.x<-2f)||(MovedBar.position.x>1.5f))
        {
            speed = 0;
            IsEnd = true;
            GorB = false;
            Panel.SetActive(true);
        }
        if (TimerWashing.NumTime==0)
        {
            speed = 0;
            IsEnd = true;
            GorB = true;
            Panel2.SetActive(true);
        }
    }

    public void OnClickColdButton()
    {
        if (DoubleClickCold)
        {
            speed *= 2;
        }
        else
        {
            speed = Random.Range(-1.5f, -0.8f) * Time.deltaTime;
        }
        DoubleClickCold = true;
        DoubleClickHot = false;
    }

    public void OnClickHotButton()
    {
        if (DoubleClickHot)
        {
            speed *= 2;
        }
        else
        {
            speed = Random.Range(0.8f, 1.5f) * Time.deltaTime;
        }
        DoubleClickCold = false;
        DoubleClickHot = true;
    }

    private void Start()
    {
        speed = Random.Range(-0.5f, 0.5f)*Time.deltaTime;
        StartCoroutine(MoveBubbles());
    }

    IEnumerator MoveBubbles()
    {
        while ((TimerWashing.NumTime > 0) && (!IsEnd))
        {
            Bubbles.transform.position = new Vector2(Random.Range(-5.1f, -4.6f), Random.Range(7.8f, 8f));
            yield return new WaitForSeconds(0.05f);
        }
    }

    private void Update()
    {
        MovedBar.position = new Vector2(MovedBar.position.x + speed, MovedBar.position.y);
        if (!IsEnd)
        {
            IsLongDistance();
        }
        else
            MovedBar.position = new Vector2(-0.225f, MovedBar.position.y);
    }
}
