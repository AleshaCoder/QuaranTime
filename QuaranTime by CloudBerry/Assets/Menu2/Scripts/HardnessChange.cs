using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardnessChange : MonoBehaviour
{
    public void Easy()
    {
        PlayerPrefs.SetInt("Hardness", 1);
    }

    public void Norm()
    {
        PlayerPrefs.SetInt("Hardness", 2);
    }

    public void Hard()
    {
        PlayerPrefs.SetInt("Hardness", 3);
    }

    public void Unreal()
    {
        PlayerPrefs.SetInt("Hardness", 4);
    }
}
