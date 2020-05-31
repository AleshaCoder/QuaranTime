using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpawnVirus : MonoBehaviour
{
    public GameObject _virus;
    public GameObject Shop,home;
    public GameObject Shop3D,Home2D;
    public Slider Timer;
    public Text NumG;
    public float SpawnTime = 0.5f;
    public static float Time = 20;

    private void Start()
    {
        StartCoroutine(_SpawnVirus());
    }
    IEnumerator _SpawnVirus()
    {
        while (Time>0)
        {
            if (Time > 4)
            {
                Instantiate(_virus, new Vector2(Random.Range(-5f, 5f), 5f), Quaternion.Euler(0, 0, 180 * Random.Range(0, 5)));
            }
            Time -=  SpawnTime;
            Timer.value = 20 - Time;
            if (Time<1)
            {
                if (!FallDown.MagOrDom)
                {
                    Shop.SetActive(true);
                    Shop3D.SetActive(false);
                }
                if (FallDown.MagOrDom)
                {
                    NumG.text = (Player.lose * 10).ToString();
                    home.SetActive(true);
                    Home2D.SetActive(false);
                }
            }
            yield return new WaitForSeconds(SpawnTime);
        }
    }
}