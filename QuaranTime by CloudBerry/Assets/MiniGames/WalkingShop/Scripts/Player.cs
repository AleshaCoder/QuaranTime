using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public static int lose = 0;
    public GameObject GameOver;
    public GameObject ButtonReturn;
    public GameObject txt;

    private void Start()
    {
        txt.GetComponent<Text>().text = lose.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Virus")
        {
            lose += 1;
            txt.GetComponent<Text>().text = lose.ToString();
        }
    }
}
