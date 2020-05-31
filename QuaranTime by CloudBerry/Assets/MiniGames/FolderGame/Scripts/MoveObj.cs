using UnityEngine;

public class MoveObj : MonoBehaviour
{
    public Transform SelfTransform;
    private float Speed = 20f;

    private void OnMouseDrag()
    {
        if (!(Score.score==12))
        {
            Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            SelfTransform.position = Vector2.MoveTowards(SelfTransform.position,
                 new Vector2(MousePos.x, MousePos.y), Speed * Time.deltaTime);
        }
            
    }
}
