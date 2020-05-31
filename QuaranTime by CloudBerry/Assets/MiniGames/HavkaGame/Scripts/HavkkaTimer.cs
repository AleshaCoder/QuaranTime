using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HavkkaTimer : MonoBehaviour
{
    public GameObject Panel1, Panel2;
    public Image _timeBar, T2,T1;
    public Text ScoreText;
    public Sprite[] Havka= new Sprite[8];
    public Image MainSprite;
    public Button un1;
    public static int NumHavka=1;
    public static int Score = 0;
    public static int Tryings = 10;
    public static float _timeFill =400f;
    public static float H0, H1, H2, H3, H4;
    private void Start()
    {
        MainSprite.sprite = PlayerController.ItemPlayerSprite;
        un1.gameObject.SetActive(true);
        StartCoroutine("TimeReducing");
    }
    public void Good()
    {
        GameTimer.HappyValue += 0.05f+H1;
        GameTimer.HealthValue += H0;
        GameTimer.GigienaValue += H2;
        GameTimer.EnergyValue += H3;
        GameTimer.HavkaValue += H4;
        SaveLoad.SavePlayerStats();
        PlayerController.ItemPlayerSprite = null;
    }
    public void Bad()
    {
        GameTimer.HealthValue -= 0.05f;
        SaveLoad.SavePlayerStats();
        PlayerController.ItemPlayerSprite = null;
    }
    public  void MD()
    {
        if (Mathf.Abs(T2.rectTransform.localPosition.x-_timeFill)<T2.rectTransform.rect.width/2)
        {
            Score += 1;
        }
        else
        {
            if (Score>0)
                Score -= 1;
        }
        ScoreText.text = Score.ToString();
        Tryings -= 1;
        if (Tryings==0)
        {
            un1.gameObject.SetActive(false);
            if (Score>4)
            {
                Panel1.SetActive(true);
            }
            else
            {
                Panel2.SetActive(true);
            }
        }
        _timeFill = T1.rectTransform.position.x + T1.rectTransform.rect.width / 2;
        _timeBar.rectTransform.localPosition = new Vector2(_timeFill, _timeBar.rectTransform.localPosition.y);
        T2.rectTransform.localPosition= new Vector2(Random.Range(-150,150), T2.rectTransform.localPosition.y);
        T2.rectTransform.sizeDelta -= new Vector2(Random.Range(T2.rectTransform.rect.width / 40, T2.rectTransform.rect.width/5), 0);
    }

    IEnumerator TimeReducing()
    {
        _timeFill = T1.rectTransform.position.x + T1.rectTransform.rect.width / 2;
        while (Tryings>0)
        {
            _timeFill -= 1.5f*(Score+1);
            _timeBar.rectTransform.localPosition = new Vector2(_timeFill, _timeBar.rectTransform.localPosition.y);
            if (_timeFill<-400)
            {
                MD();
            }
            yield return new WaitForSeconds(0.01f);
        }
    }
}
