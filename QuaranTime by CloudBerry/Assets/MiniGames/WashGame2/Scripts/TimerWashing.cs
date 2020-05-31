using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerWashing : MonoBehaviour
{
    public Text _time;
    public static int NumTime = 20;

    private void Start()
    {
        NumTime = 20;
        _time.text = NumTime.ToString();
        StartCoroutine(Timer());
    }
    IEnumerator Timer()
    {
        while ((NumTime>0)&&(!BarMover.IsEnd))
        {
            NumTime -= 1;
            _time.text = NumTime.ToString();
            yield return new WaitForSeconds(1f);
        }
    }
}
