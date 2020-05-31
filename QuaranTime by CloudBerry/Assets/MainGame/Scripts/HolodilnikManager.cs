using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HolodilnikManager : MonoBehaviour
{
    public Text Amount;
    public Button Eats;
    public Image FoodImage;
    public Sprite[] Havka;
    private bool[] having=new bool[15];
    private byte qq;
    private bool first=true;
    public Button RB, LB;
    public int Numhav=0;

    public void OnLeft()
    {
        if (FoodImage.gameObject.activeInHierarchy)
        {
            Numhav--;
            if (Numhav < 0)
                Numhav = 14;
            while (!having[Numhav])
            {
                Numhav--;
                if (Numhav < 0)
                    Numhav = 14;
            }
            LoadNumHavka();
            RefreshText();
        }
    }

    public void OnRight()
    {
        if (FoodImage.gameObject.activeInHierarchy)
        {
            Numhav++;
            if (Numhav > 14)
                Numhav = 0;
            while (!having[Numhav])
            {
                Numhav++;
                if (Numhav > 14)
                    Numhav = 0;
            }
            LoadNumHavka();
            RefreshText();
        }
    }

    public void Eat()
    {
        switch (Numhav)
        {
            case 0:
                if (Apple.Amount>0)
                {
                    Apple.Amount -= 1;
                    GameTimer.HealthValue += Apple.Help[0]/100.0f;
                    GameTimer.HappyValue += Apple.Help[1] / 100.0f;
                    GameTimer.GigienaValue += Apple.Help[2] / 100.0f;
                    GameTimer.EnergyValue += Apple.Help[3] / 100.0f;
                    GameTimer.HavkaValue += Apple.Help[4] / 100.0f;
                }
                break;
            case 1:
                if (Limon.Amount>0)
                {
                    Limon.Amount -= 1;
                    GameTimer.HealthValue += Limon.Help[0] / 100.0f;
                    GameTimer.HappyValue += Limon.Help[1] / 100.0f;
                    GameTimer.GigienaValue += Limon.Help[2] / 100.0f;
                    GameTimer.EnergyValue += Limon.Help[3] / 100.0f;
                    GameTimer.HavkaValue += Limon.Help[4] / 100.0f;
                }
                break;
            case 2:
                if (Potato.Amount>0)
                {
                    Potato.Amount -= 1;
                    HavkkaTimer.H0 = Potato.Help[0] / 100.0f;
                    HavkkaTimer.H1 = Potato.Help[1] / 100.0f;
                    HavkkaTimer.H2 = Potato.Help[2] / 100.0f;
                    HavkkaTimer.H3 = Potato.Help[3] / 100.0f;
                    HavkkaTimer.H4 = Potato.Help[4] / 100.0f;
                    gameObject.SetActive(false);
                }
                break;
            case 3:
                if (Onion.Amount>0)
                {
                    Onion.Amount -= 1;
                    GameTimer.HealthValue += Onion.Help[0] / 100.0f;
                    GameTimer.HappyValue += Onion.Help[1] / 100.0f;
                    GameTimer.GigienaValue += Onion.Help[2] / 100.0f;
                    GameTimer.EnergyValue += Onion.Help[3] / 100.0f;
                    GameTimer.HavkaValue += Onion.Help[4] / 100.0f;
                }
                break;
            case 4:
                if (Milk.Amount>0)
                {
                    Milk.Amount -= 1;
                    GameTimer.HealthValue += Milk.Help[0] / 100.0f;
                    GameTimer.HappyValue += Milk.Help[1] / 100.0f;
                    GameTimer.GigienaValue += Milk.Help[2] / 100.0f;
                    GameTimer.EnergyValue += Milk.Help[3] / 100.0f;
                    GameTimer.HavkaValue += Milk.Help[4] / 100.0f;
                }
                break;
            case 5:
                if (Cheese.Amount>0)
                {
                    Cheese.Amount -= 1;
                    GameTimer.HealthValue += Cheese.Help[0] / 100.0f;
                    GameTimer.HappyValue += Cheese.Help[1] / 100.0f;
                    GameTimer.GigienaValue += Cheese.Help[2] / 100.0f;
                    GameTimer.EnergyValue += Cheese.Help[3] / 100.0f;
                    GameTimer.HavkaValue += Cheese.Help[4] / 100.0f;
                }
                break;
            case 6:
                if (Yoghurt.Amount>0)
                {
                    Yoghurt.Amount -= 1;
                    GameTimer.HealthValue += Yoghurt.Help[0] / 100.0f;
                    GameTimer.HappyValue += Yoghurt.Help[1] / 100.0f;
                    GameTimer.GigienaValue += Yoghurt.Help[2] / 100.0f;
                    GameTimer.EnergyValue += Yoghurt.Help[3] / 100.0f;
                    GameTimer.HavkaValue += Yoghurt.Help[4] / 100.0f;
                }
                break;
            case 7:
                if (IceCream.Amount>0)
                {
                    IceCream.Amount -= 1;
                    GameTimer.HealthValue += IceCream.Help[0] / 100.0f;
                    GameTimer.HappyValue += IceCream.Help[1] / 100.0f;
                    GameTimer.GigienaValue += IceCream.Help[2] / 100.0f;
                    GameTimer.EnergyValue += IceCream.Help[3] / 100.0f;
                    GameTimer.HavkaValue += IceCream.Help[4] / 100.0f;
                }
                break;
            case 8:
                if (Chicken.Amount>0)
                {
                    Chicken.Amount -= 1;
                    HavkkaTimer.H0 = Chicken.Help[0] / 100.0f;
                    HavkkaTimer.H1 = Chicken.Help[1] / 100.0f;
                    HavkkaTimer.H2 = Chicken.Help[2] / 100.0f;
                    HavkkaTimer.H3 = Chicken.Help[3] / 100.0f;
                    HavkkaTimer.H4 = Chicken.Help[4] / 100.0f;
                    gameObject.SetActive(false);
                }
                break;
            case 9:
                if (Beef.Amount>0)
                {
                    Beef.Amount -= 1;
                    HavkkaTimer.H0 = Beef.Help[0] / 100.0f;
                    HavkkaTimer.H1 = Beef.Help[1] / 100.0f;
                    HavkkaTimer.H2 = Beef.Help[2] / 100.0f;
                    HavkkaTimer.H3 = Beef.Help[3] / 100.0f;
                    HavkkaTimer.H4 = Beef.Help[4] / 100.0f;
                    gameObject.SetActive(false);
                }
                break;
            case 10:
                if (Cutlet.Amount>0)
                {
                    Cutlet.Amount -= 1;
                    HavkkaTimer.H0 = Cutlet.Help[0] / 100.0f;
                    HavkkaTimer.H1 = Cutlet.Help[1] / 100.0f;
                    HavkkaTimer.H2 = Cutlet.Help[2] / 100.0f;
                    HavkkaTimer.H3 = Cutlet.Help[3] / 100.0f;
                    HavkkaTimer.H4 = Cutlet.Help[4] / 100.0f;
                    gameObject.SetActive(false);
                }
                break;
            case 11:
                if (Nuddles.Amount>0)
                {
                    Nuddles.Amount -= 1;
                    HavkkaTimer.H0 = Nuddles.Help[0] / 100.0f;
                    HavkkaTimer.H1 = Nuddles.Help[1] / 100.0f;
                    HavkkaTimer.H2 = Nuddles.Help[2] / 100.0f;
                    HavkkaTimer.H3 = Nuddles.Help[3] / 100.0f;
                    HavkkaTimer.H4 = Nuddles.Help[4] / 100.0f;
                    gameObject.SetActive(false);
                }
                break;
            case 12:
                if (Rise.Amount>0)
                {
                    Rise.Amount -= 1;
                    HavkkaTimer.H0 = Rise.Help[0] / 100.0f;
                    HavkkaTimer.H1 = Rise.Help[1] / 100.0f;
                    HavkkaTimer.H2 = Rise.Help[2] / 100.0f;
                    HavkkaTimer.H3 = Rise.Help[3] / 100.0f;
                    HavkkaTimer.H4 = Rise.Help[4] / 100.0f;
                    gameObject.SetActive(false);
                }
                break;
            case 13:
                if (Buckwheat.Amount>0)
                {
                    Buckwheat.Amount -= 1;
                    HavkkaTimer.H0 = Buckwheat.Help[0] / 100.0f;
                    HavkkaTimer.H1 = Buckwheat.Help[1] / 100.0f;
                    HavkkaTimer.H2 = Buckwheat.Help[2] / 100.0f;
                    HavkkaTimer.H3 = Buckwheat.Help[3] / 100.0f;
                    HavkkaTimer.H4 = Buckwheat.Help[4] / 100.0f;
                    gameObject.SetActive(false);
                }
                break;
            case 14:
                if (Pasta.Amount>0)
                {
                    Pasta.Amount -= 1;
                    HavkkaTimer.H0= Pasta.Help[0] / 100.0f;
                    HavkkaTimer.H1 = Pasta.Help[1] / 100.0f;
                    HavkkaTimer.H2 = Pasta.Help[2] / 100.0f;
                    HavkkaTimer.H3 = Pasta.Help[3] / 100.0f;
                    HavkkaTimer.H4 = Pasta.Help[4] / 100.0f;
                    gameObject.SetActive(false);
                }
                break;
        }
        SaveLoad.SaveParametrs();
        SaveLoad.SavePlayerStats();
        while (!having[Numhav])
        {
            Numhav++;
            if (Numhav > 14)
                Numhav = 0;
        }
        RefreshText();
    }

    public void LoadNumHavka()
    {
        if (Apple.Amount != 0)
        {
            having[0]=true;
        }
        else having[0] = false;
        if (Limon.Amount != 0)
        {
            having[1] = true;
        }
        else having[1] = false;
        if (Potato.Amount != 0)
        {
            having[2] = true;
        }
        else having[2] = false;
        if (Onion.Amount != 0)
        {
            having[3] = true;
        }
        else having[3] = false;
        if (Milk.Amount != 0)
        {
            having[4] = true;
        }
        else having[4] = false;
        if (Cheese.Amount != 0)
        {
            having[5] = true;
        }
        else having[5] = false;
        if (Yoghurt.Amount != 0)
        {
            having[6] = true;
        }
        else having[6] = false;
        if (IceCream.Amount != 0)
        {
            having[7] = true;
        }
        else having[7] = false;
        if (Chicken.Amount != 0)
        {
            having[8] = true;
        }
        else having[8] = false;
        if (Beef.Amount != 0)
        {
            having[9] = true;
        }
        else having[9] = false;
        if (Cutlet.Amount != 0)
        {
            having[10] = true;
        }
        else having[10] = false;
        if (Nuddles.Amount != 0)
        {
            having[11] = true;
        }
        else having[11] = false;
        if (Rise.Amount != 0)
        {
            having[12] = true;
        }
        else having[12] = false;
        if (Buckwheat.Amount != 0)
        {
            having[13] = true;
        }
        else having[13] = false;
        if (Pasta.Amount != 0)
        {
            having[14] = true;
        }
        else having[14] = false;
        for (int i=0;i<15;i++)
        {
            if (having[i])
            {
                qq += 1;
                if (first)
                {
                    Numhav = i;
                    first = false;
                    FoodImage.sprite = Havka[i];
                    RefreshText();
                }
                break;
            }
        }
        if (qq == 0)
        {
            FoodImage.gameObject.SetActive(false);
        }
        else
            qq = 0;
    }

    private void SelectActivity()
    {
        Eats.onClick.RemoveAllListeners();
        Eats.onClick.AddListener(() => Eat());
    }

    private void RefreshText()
    {
        switch (Numhav)
        {
            case 0:
                Amount.text = Apple.Amount.ToString();
                Eats.GetComponentInChildren<Text>().text = "Съесть";
                break;
            case 1:
                Amount.text = Limon.Amount.ToString();
                Eats.GetComponentInChildren<Text>().text = "Съесть";
                break;
            case 2:
                Amount.text = Potato.Amount.ToString();
                Eats.GetComponentInChildren<Text>().text = "Взять";
                PlayerController.ItemPlayerSprite = Havka[Numhav];
                break;
            case 3:
                Amount.text = Onion.Amount.ToString();
                Eats.GetComponentInChildren<Text>().text = "Съесть";
                break;
            case 4:
                Amount.text = Milk.Amount.ToString();
                Eats.GetComponentInChildren<Text>().text = "Съесть";
                break;
            case 5:
                Amount.text = Cheese.Amount.ToString();
                Eats.GetComponentInChildren<Text>().text = "Съесть";
                break;
            case 6:
                Amount.text = Yoghurt.Amount.ToString();
                Eats.GetComponentInChildren<Text>().text = "Съесть";
                break;
            case 7:
                Amount.text = IceCream.Amount.ToString();
                Eats.GetComponentInChildren<Text>().text = "Съесть";
                break;
            case 8:
                Amount.text = Chicken.Amount.ToString();
                PlayerController.ItemPlayerSprite = Havka[Numhav];
                Eats.GetComponentInChildren<Text>().text = "Взять";
                break;
            case 9:
                Amount.text = Beef.Amount.ToString();
                PlayerController.ItemPlayerSprite = Havka[Numhav];
                Eats.GetComponentInChildren<Text>().text = "Взять";
                break;
            case 10:
                Amount.text = Cutlet.Amount.ToString();
                PlayerController.ItemPlayerSprite = Havka[Numhav];
                Eats.GetComponentInChildren<Text>().text = "Взять";
                break;
            case 11:
                Amount.text = Nuddles.Amount.ToString();
                PlayerController.ItemPlayerSprite = Havka[Numhav];
                Eats.GetComponentInChildren<Text>().text = "Взять";
                break;
            case 12:
                Amount.text = Rise.Amount.ToString();
                PlayerController.ItemPlayerSprite = Havka[Numhav];
                Eats.GetComponentInChildren<Text>().text = "Взять";
                break;
            case 13:
                Amount.text = Buckwheat.Amount.ToString();
                PlayerController.ItemPlayerSprite = Havka[Numhav];
                Eats.GetComponentInChildren<Text>().text = "Взять";
                break;
            case 14:
                Amount.text = Pasta.Amount.ToString();
                PlayerController.ItemPlayerSprite = Havka[Numhav];
                Eats.GetComponentInChildren<Text>().text = "Взять";
                break;
        }
        SelectActivity();
        FoodImage.sprite = Havka[Numhav];
    }

    private void Start()
    {
        LoadNumHavka();
    }
}