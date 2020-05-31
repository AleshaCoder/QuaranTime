using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMover : MonoBehaviour
{
    [SerializeField] private float FallSpeed = 4f;

    private void RoadMove()
    {
        if (SpawnVirus.Time > 0)
        {
            transform.position -= new Vector3(0, FallSpeed * 0.02f, 0);
            if (transform.position.y <= -8)
            {
                transform.position = new Vector3(0, 11.9f, 100);
            }
        }
    }
    void Start()
    {
        StartCoroutine(MoveTimer());
    }
    IEnumerator MoveTimer()
    {
        while (SpawnVirus.Time>0)
        {
            RoadMove();
            yield return new WaitForSeconds(0.02f);
        }
    }
}
