using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;

    private void Start()
    {
        score = 0;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 25), "Очки: " + score);
    }
}
