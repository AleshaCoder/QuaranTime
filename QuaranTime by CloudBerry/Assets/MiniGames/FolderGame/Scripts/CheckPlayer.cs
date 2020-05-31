using UnityEngine;

public class CheckPlayer : MonoBehaviour
{
    public GameObject obj;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(obj);
            Score.score++;
        }
    }
}
