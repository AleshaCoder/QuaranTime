using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DistanceGarden : MonoBehaviour
{
    #region Fields
    public GameObject[] MainObjects;
    public GameObject Player;
    public Button ActivityButton;
    public GameObject Shkaf, Holodilnik;
    public GameObject trututu;

    #endregion

    #region Private Methods
    private void Cheaker()
    {
        if ((Player.transform.position - MainObjects[0].transform.position).sqrMagnitude < 5)
        {
            ActivityButton.gameObject.SetActive(true);
            ActivityButton.GetComponentInChildren<Text>().text = "Вернуться домой";
            ActivityButton.onClick.RemoveAllListeners();
            SaveLoad.SavePlayerStats();
            ActivityButton.onClick.AddListener(() => ActivityButton.GetComponent<SceneLoader>().Loading(1));
            ActivityButton.onClick.AddListener(() => GameTimer.LoadStats=true);
        }
        if ((Player.transform.position - MainObjects[1].transform.position).sqrMagnitude < 5)
        {
            ActivityButton.gameObject.SetActive(true);
            ActivityButton.GetComponentInChildren<Text>().text = "Рыбачить";
            ActivityButton.onClick.RemoveAllListeners();
            PlayerPrefs.SetFloat("PosX", -18);
            PlayerPrefs.SetFloat("PosY", -3);
            PlayerPrefs.SetFloat("PosZ", 90);
            PlayerPrefs.SetFloat("RotX", 0);
            PlayerPrefs.SetFloat("RotY", 0);
            PlayerPrefs.SetFloat("RotZ", -90);
        }
        if ((Player.transform.position - MainObjects[2].transform.position).sqrMagnitude < 5)
        {
            ActivityButton.gameObject.SetActive(true);
            ActivityButton.GetComponentInChildren<Text>().text = "Сходить в магазин";
            ActivityButton.onClick.RemoveAllListeners();
            SaveLoad.SavePlayerStats();
            ActivityButton.onClick.AddListener(() => ActivityButton.GetComponent<SceneLoader>().Loading(2));
            //ActivityButton.onClick.AddListener(() => trututu.GetComponent<GardenTimer>().SavePlayerPosition());
        }
        if ((Player.transform.position - MainObjects[3].transform.position).sqrMagnitude < 5)
        {
            ActivityButton.gameObject.SetActive(true);
            ActivityButton.GetComponentInChildren<Text>().text = "Поторговаться с Алексеем";
            ActivityButton.onClick.RemoveAllListeners();
            //ActivityButton.onClick.AddListener(() => ActivityButton.GetComponent<SonManager>().Son());
        }

        if (((Player.transform.position - MainObjects[2].transform.position).sqrMagnitude >= 5)
            && ((Player.transform.position - MainObjects[1].transform.position).sqrMagnitude >= 5)
            && ((Player.transform.position - MainObjects[0].transform.position).sqrMagnitude >= 5)
            && ((Player.transform.position - MainObjects[3].transform.position).sqrMagnitude >= 5))
        {
            ActivityButton.gameObject.SetActive(false);
        }
    }
    #endregion

    #region Unity Methods
    private void Start()
    {
        SaveLoad.LoadPlayerStats();
    }

    private void FixedUpdate()
    {
        Cheaker();
    }
    #endregion
}
