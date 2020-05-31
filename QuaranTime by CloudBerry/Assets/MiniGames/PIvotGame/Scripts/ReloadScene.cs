using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadScene : MonoBehaviour
{
public void Realoading()
    {
        TimeBar.Fill = 1f;
        TimeBar.q1 = false;
        HitCheck.Score = 0;
    }
}
