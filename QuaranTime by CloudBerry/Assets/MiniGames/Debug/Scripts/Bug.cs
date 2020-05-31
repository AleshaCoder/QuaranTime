using System.Collections;
using UnityEngine;

public class Bug : MonoBehaviour
{
    public static int Score = 0;
    public AudioSource Music;
    public AudioSource _hit;

    private void OnMouseDown()
    {
        if (TimeBar2.Fill > 0)
        {
            Score++;
            transform.position = new Vector2(Random.Range(-5.8f, 5.8f), Random.Range(-4.5f, 4.4f));
            _hit.Play();
        }
    }


    private void Start()
    {
        StartCoroutine("Respawn");
    }


    IEnumerator Respawn()
    {
        while (TimeBar2.Fill > 0)
        {
            transform.position = new Vector2(Random.Range(-5.8f, 5.8f), Random.Range(-4.5f, 4.4f));
            yield return new WaitForSeconds(1f);
        }
        if (TimeBar2.Fill <= 0)
            Music.Stop();
    }
}
