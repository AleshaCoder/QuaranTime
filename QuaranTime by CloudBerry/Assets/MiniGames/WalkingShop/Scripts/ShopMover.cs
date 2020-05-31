using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMover : MonoBehaviour
{
    [SerializeField] private float FallSpeed = 4f;
    public GameObject Shop, Home;
    private void ShopMove()
    {
        if ( (SpawnVirus.Time > 0)&&(SpawnVirus.Time < 2))
        {
            if (!FallDown.MagOrDom)
            {
                Shop.gameObject.SetActive(true);
                Shop.transform.position -= new Vector3(0, FallSpeed * 0.02f, 0);
                if (Shop.transform.position.y <= -8)
                    Shop.transform.position = new Vector3(0, 11.9f, 100);
            }
            if (FallDown.MagOrDom)
            {
                Home.gameObject.SetActive(true);
                Home.transform.position -= new Vector3(0, FallSpeed * 0.02f, 0);
                if (Home.transform.position.y <= -8)
                    Home.transform.position = new Vector3(0, 11.9f, 100);
            }
            
        }
    }
    void Start()
    {
        StartCoroutine(MoveTimer());
    }
    IEnumerator MoveTimer()
    {
        while (SpawnVirus.Time > 0)
        {
            ShopMove();
            yield return new WaitForSeconds(0.02f);
        }
    }
}
