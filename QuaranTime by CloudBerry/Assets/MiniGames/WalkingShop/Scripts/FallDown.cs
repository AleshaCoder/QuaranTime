using UnityEngine;
using System.Collections;

public class FallDown : MonoBehaviour
{
    #region Fields
    public static bool MagOrDom = false;
    [SerializeField] private float FallSpeed = 4f;
    #endregion

    #region Private Methods
    private void VirusMover()
    {
            transform.position -= new Vector3(0, FallSpeed * 0.02f, 0);
    }

    private void VirusDestructor()
    {
        if (transform.position.y <= -11f)
        {
            Destroy(gameObject);
        }
    }
    #endregion

    void Start()
    {
        StartCoroutine(MoveVirusTimer());
    }
    IEnumerator MoveVirusTimer()
    {
        while (SpawnVirus.Time > 0)
        {
            VirusMover();
            VirusDestructor();
            yield return new WaitForSeconds(0.02f);
        }
    }
}