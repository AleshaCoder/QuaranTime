using UnityEngine;
using UnityEngine.UI;

public class GameProcess : MonoBehaviour
{
    public GameObject[] objs;
    public AudioSource[] sounds;
    public Image Bar2;
    public GameObject Bubles;
    public  Text Score;
    private bool End = false;
    public static float NumClicks=0;
    private void Update()
    {
        if (WashTimer.Fill <= 0)
        {
            End = true;
        }
    }
    private void OnMouseDown()
    { 
        if (!End)
        {
            sounds[2].Play();
            objs[2].SetActive(true);
            //objs[1].GetComponent<Animator>().SetBool("wash", true);
            NumClicks += 0.01f;
            Debug.Log(NumClicks);
            Bar2.fillAmount = NumClicks;
            Score.text = (NumClicks * 100).ToString("0");
            Bubles.gameObject.transform.position = new Vector2(Random.Range(-3.0f, 1.5f), Random.Range(-7.0f, -4));
        }
        else
        {
            objs[2].SetActive(false);
            //objs[1].GetComponent<Animator>().SetBool("wash", false);
        }
    }
}