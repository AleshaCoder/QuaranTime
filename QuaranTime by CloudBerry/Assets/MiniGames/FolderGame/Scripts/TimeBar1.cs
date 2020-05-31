using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimeBar1 : MonoBehaviour
{
    public Camera mc;
    public GameObject End;
    public AudioSource Music;
    private void Start()
    {
        StartCoroutine("Timer");
    }
    IEnumerator Timer()
    {
        while (Score.score <= 12)
        {
            
            if (Score.score == 12)
            {
                End.SetActive(true);
                Music.Stop();
            }
            yield return new WaitForSeconds(0.5f);
        }
    }

}
