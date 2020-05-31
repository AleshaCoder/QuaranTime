using UnityEngine;

public class CheckIcon : MonoBehaviour
{
    public GameObject obj;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Icons")
        {
            Destroy(obj);
            Score.score++;
        }
    }
}
