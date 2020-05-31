using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadHavka : MonoBehaviour
{
public void Reloading()
    {
        HavkkaTimer.Score = 0;
        HavkkaTimer.Tryings = 10;
    }
}
