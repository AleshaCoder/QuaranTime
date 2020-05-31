using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShkafManager : MonoBehaviour
{
    public Text[] Amounts;
    public GameObject Panel;

    public void VitsEat()
    {
        if (Vits.Amount>0)
        {
            GameTimer.HealthValue += 0.1f;
            Vits.Amount -= 1;
            GameTimer.HappyValue += 0.1f;
        }
        
    }
    public void AntiEat()
    {
        if (Antibiotics.Amount>0)
        {
        GameTimer.HealthValue += 0.5f;
        Antibiotics.Amount -= 1;
        }
    }
    void Update()
    {
        if (Panel.activeInHierarchy)
        {
            Amounts[0].text = Soup.Amount.ToString();
            Amounts[1].text = Paper.Amount.ToString();
            Amounts[2].text = Antiseptic.Amount.ToString();
            Amounts[3].text = Mask.Amount.ToString();
            Amounts[4].text = Vits.Amount.ToString();
            Amounts[5].text = Antibiotics.Amount.ToString();
        }
    }
}
