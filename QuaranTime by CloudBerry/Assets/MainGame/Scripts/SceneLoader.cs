using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Image Blank;
    private int SceneID;
    public Image[] LoadingImage;
    public Text ProgressText;
    public Button ActivityButton;
    public GameObject Muz;
    public void Loading(int ID)
    {
        Blank.gameObject.SetActive(true);
        for (int i = 0; i < LoadingImage.Length; i++)
        {
            LoadingImage[i].gameObject.SetActive(true);
        }
        SceneID = ID;
        if (SceneID==1)
        {
            GameTimer.MainSceneIsActive = true;
            if (PlayerPrefs.HasKey("Health"))
            {
                GameTimer.LoadStats = true;
            }
            else
            {
                GameTimer.LoadStats = false;
            }
        }
        else
        {
            SaveLoad.SavePlayerStats();
            SaveLoad.SaveParametrs();
            GameTimer.MainSceneIsActive = false;
        }
        StartCoroutine(SyncLoad());
    }

    IEnumerator SyncLoad()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneID);
        while (operation.progress<0.9f)
        {
            float progress = operation.progress / 0.9f;
            for (int i = 0; i < LoadingImage.Length; i++)
            {
                LoadingImage[i].fillAmount = progress;
            }
            ProgressText.text = string.Format("{0:0}%", progress);
            yield return  null;
        }
    }
}
