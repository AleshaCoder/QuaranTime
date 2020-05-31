using UnityEngine;

public class MovePivod : MonoBehaviour
{
    public Transform SelfTransform;
    [SerializeField] private float MoveSpeed = 3f;
    public AudioSource _Audio1;
    public AudioSource _Audio2;
    public GameObject End;

    private void OnMouseDrag()
    {
        if (TimeBar.Fill > 0)
        {
                Vector3 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                SelfTransform.position = Vector2.MoveTowards(SelfTransform.position,
                    new Vector2(MousePos.x, MousePos.y), MoveSpeed * Time.deltaTime*5);
        }
    }
}