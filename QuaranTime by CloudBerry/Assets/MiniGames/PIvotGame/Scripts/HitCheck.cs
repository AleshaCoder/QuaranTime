using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HitCheck : MonoBehaviour
{
    public AudioSource audioSource;
    private GameObject Character;
    public GameObject Pivod;
    public GameObject[] Characters;
    public static bool Respawning = false;
    public static bool ZoneXXX = false;
    public static int Score;

    private void Start()
    {
        Character = Instantiate(Characters[Random.Range(0, Characters.Length-1)]);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zone")
        { 
            ZoneXXX = true;
            Pivod.GetComponent<SpriteRenderer>().color = new Color32(80, 255, 0, 150);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zone")
        {
            ZoneXXX = false;
            Pivod.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
        }
    }

    private void OnMouseUp()
    {
        if (ZoneXXX)
        {
            Pivod.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
            audioSource.Play();
            Score += 1;
            Respawn();
            ZoneXXX = false;
        } 
    }

    void Respawn()
    {
        Destroy(Character);
        Character = Instantiate(Characters[Random.Range(0, Characters.Length - 1)]);
        Character.transform.position = new Vector2(Random.Range(-0.9f, 1.5f), Random.Range(0.0f, -1.5f));
        Pivod.transform.position = new Vector2(Random.Range(-1f, 1f), Random.Range(0.15f, -1.15f));
        Pivod.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
    }

}

