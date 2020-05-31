using UnityEngine;

public class CheckBG : MonoBehaviour
{
    public GameObject obj;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BG")
        {
            Destroy(obj);
            Score.score++;
        }
    }
}
