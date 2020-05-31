using System.Collections;
using UnityEngine;

public class SpawnObjs : MonoBehaviour
{
    public GameObject[] objs;


    void Start()
    {
        StartCoroutine("Spawn");
    }


    IEnumerator Spawn()
    {
        foreach (var obj in objs)
        {
            Instantiate(obj, new Vector2(Random.Range(-5f, 5f), Random.Range(4f, 1f)), Quaternion.identity);
        }

        yield return null;

    }


}
