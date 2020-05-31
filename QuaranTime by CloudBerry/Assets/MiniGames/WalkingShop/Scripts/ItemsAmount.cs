using UnityEngine;
using UnityEngine.UI;
public class ItemsAmount : MonoBehaviour
{
    public Text[] Texts;
    public Text[] Texts2;
    public Text MoneyA;
    public Button Buys;
    public static bool IsShop=false;
    public void Start()
    {
        RefreshTexts();
    }

    public void Buy(int Num)
    {
        switch (Num)
        {
            case 1:
                if (Money.Amount>=Apple.Price)
                {
                    Money.Amount -= Apple.Price;
                    Apple.Amount += 1;
                }
                break;
            case 2:
                if (Money.Amount >= Limon.Price)
                {
                    Money.Amount -= Limon.Price;
                    Limon.Amount += 1;
                }
                break;
            case 3:
                if (Money.Amount >= Potato.Price)
                {
                    Money.Amount -= Potato.Price;
                    Potato.Amount += 1;
                }
                break;
            case 4:
                if (Money.Amount >= Onion.Price)
                {
                    Money.Amount -= Onion.Price;
                    Onion.Amount += 1;
                }
                break;
            case 5:
                if (Money.Amount >= Milk.Price)
                {
                    Money.Amount -= Milk.Price;
                    Milk.Amount += 1;
                }
                break;
            case 6:
                if (Money.Amount >= Cheese.Price)
                {
                    Money.Amount -= Cheese.Price;
                    Cheese.Amount += 1;
                }
                break;
            case 7:
                if (Money.Amount >= Yoghurt.Price)
                {
                    Money.Amount -= Yoghurt.Price;
                    Yoghurt.Amount += 1;
                }
                break;
            case 8:
                if (Money.Amount >= IceCream.Price)
                {
                    Money.Amount -= IceCream.Price;
                    IceCream.Amount += 1;
                }
                break;
            case 9:
                if (Money.Amount >= Chicken.Price)
                {
                    Money.Amount -= Chicken.Price;
                    Chicken.Amount += 1;
                }
                break;
            case 10:
                if (Money.Amount >= Beef.Price)
                {
                    Money.Amount -= Beef.Price;
                    Beef.Amount += 1;
                }
                break;
            case 11:
                if (Money.Amount >= Cutlet.Price)
                {
                    Money.Amount -= Cutlet.Price;
                    Cutlet.Amount += 1;
                }
                break;
            case 12:
                if (Money.Amount >= Nuddles.Price)
                {
                    Money.Amount -= Nuddles.Price;
                    Nuddles.Amount += 1;
                }
                break;
            case 13:
                if (Money.Amount >= Rise.Price)
                {
                    Money.Amount -= Rise.Price;
                    Rise.Amount += 1;
                }
                break;
            case 14:
                if (Money.Amount >= Buckwheat.Price)
                {
                    Money.Amount -= Buckwheat.Price;
                    Buckwheat.Amount += 1;
                }
                break;
            case 15:
                if (Money.Amount >= Pasta.Price)
                {
                    Money.Amount -= Pasta.Price;
                    Pasta.Amount += 1;
                }
                break;
            case 16:
                if (Money.Amount >= Antibiotics.Price)
                {
                    Money.Amount -= Antibiotics.Price;
                    Antibiotics.Amount += 1;
                }
                break;
            case 17:
                if (Money.Amount >= Antiseptic.Price)
                {
                    Money.Amount -= Antiseptic.Price;
                    Antiseptic.Amount += 1;
                }
                break;
            case 18:
                if (Money.Amount >= Mask.Price)
                {
                    Money.Amount -= Mask.Price;
                    Mask.Amount += 1;
                }
                break;
            case 19:
                if (Money.Amount >= Soup.Price)
                {
                    Money.Amount -= Soup.Price;
                    Soup.Amount += 1;
                }
                break;
            case 20:
                if (Money.Amount >= Paper.Price)
                {
                    Money.Amount -= Paper.Price;
                    Paper.Amount += 1;
                }
                break;
            case 21:
                if (Money.Amount >= Vits.Price)
                {
                    Money.Amount -= Vits.Price;
                    Vits.Amount += 1;
                }
                break;
        }

        SaveLoad.SaveParametrs();
        RefreshTexts();
    }
    public void GotoHome ()
    {
        IsShop = true;
    }

    public void RefreshTexts ()
    {
        Texts[0].text = Apple.Amount.ToString();
        Texts[1].text = Limon.Amount.ToString();
        Texts[2].text = Potato.Amount.ToString();
        Texts[3].text = Onion.Amount.ToString();
        Texts[4].text = Milk.Amount.ToString() ;
        Texts[5].text = Cheese.Amount.ToString();
        Texts[6].text = Yoghurt.Amount.ToString();
        Texts[7].text = IceCream.Amount.ToString();
        Texts[8].text = Chicken.Amount.ToString();
        Texts[9].text = Beef.Amount.ToString();
        Texts[10].text = Cutlet.Amount.ToString();
        Texts[11].text = Nuddles.Amount.ToString();
        Texts[12].text = Rise.Amount.ToString();
        Texts[13].text = Buckwheat.Amount.ToString();
        Texts[14].text = Pasta.Amount.ToString();
        Texts[15].text = Antibiotics.Amount.ToString();
        Texts[16].text = Antiseptic.Amount.ToString();
        Texts[17].text = Mask.Amount.ToString();
        Texts[18].text = Soup.Amount.ToString();
        Texts[19].text = Paper.Amount.ToString();
        Texts[20].text = Vits.Amount.ToString();
        Texts2[0].text = Apple.Price.ToString() + "P";
        Texts2[1].text = Limon.Price.ToString() + "P";
        Texts2[2].text = Potato.Price.ToString() + "P";
        Texts2[3].text = Onion.Price.ToString() + "P";
        Texts2[4].text = Milk.Price.ToString() + "P";
        Texts2[5].text = Cheese.Price.ToString() + "P";
        Texts2[6].text = Yoghurt.Price.ToString() + "P";
        Texts2[7].text = IceCream.Price.ToString() + "P";
        Texts2[8].text = Chicken.Price.ToString() + "P";
        Texts2[9].text = Beef.Price.ToString() + "P";
        Texts2[10].text = Cutlet.Price.ToString() + "P";
        Texts2[11].text = Nuddles.Price.ToString() + "P";
        Texts2[12].text = Rise.Price.ToString() + "P";
        Texts2[13].text = Buckwheat.Price.ToString() + "P";
        Texts2[14].text = Pasta.Price.ToString() + "P";
        Texts2[15].text = Antibiotics.Price.ToString() + "P";
        Texts2[16].text = Antiseptic.Price.ToString() + "P";
        Texts2[17].text = Mask.Price.ToString() + "P";
        Texts2[18].text = Soup.Price.ToString() + "P";
        Texts2[19].text = Paper.Price.ToString() + "P";
        Texts2[20].text = Vits.Price.ToString() + "P";
        MoneyA.text = Money.Amount.ToString()+"P";
    }
}
