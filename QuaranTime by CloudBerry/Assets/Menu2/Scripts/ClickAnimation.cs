using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAnimation : MonoBehaviour
{
    public GameObject Virus;
    public static bool Cl = false;
    private Vector3 MousePos;
    public void OnMouseDown()
    {
        GameObject V3 = Instantiate(Virus);
        MousePos = Input.mousePosition;
        Vector2 CP = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        V3.transform.position = new Vector3(CP.x, CP.y, 90);
        Cl = true;
        Destroy(V3, 0.5f);
    }
}
