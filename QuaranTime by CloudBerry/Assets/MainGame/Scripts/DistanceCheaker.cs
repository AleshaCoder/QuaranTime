using UnityEngine;
using UnityEngine.UI;

public class DistanceCheaker : MonoBehaviour
{
    #region Fields
    public GameObject[] MainObjects;
    public GameObject Player;
    public Button ActivityButton;
    public GameObject Shkaf, Holodilnik;

    private bool _IsNearestObject = false;
    private readonly string[] _ActivityButtonText = { "Спать", "Выйти на улицу", "Работать", "Помыть руки", "Открыть холодильник", "Приготовить пожрать", "Порыться в вещах", "Помыться в душе" };
    private readonly byte[] _LoadingScene = { 0, 10, 5, 4, 0, 8, 0, 9 };
    #endregion

    #region Private Methods

    private void OtherEvent(int i)
    {
        switch (i)
        {
            case 0:
                ActivityButton.onClick.AddListener(() => ActivityButton.GetComponent<SonManager>().Son());
                break;
            case 1:
                ActivityButton.onClick.AddListener(() => GameTimer.LoadStats = true);
                break;
            case 4:
                ActivityButton.onClick.AddListener(() => Holodilnik.SetActive(true));
                break;
            case 6:
                ActivityButton.onClick.AddListener(() => Shkaf.SetActive(true));
                break;
        }
    }

    private void GetClickEvent(int i)
    {
        ActivityButton.gameObject.SetActive(true);
        ActivityButton.GetComponentInChildren<Text>().text = _ActivityButtonText[i];
        ActivityButton.onClick.RemoveAllListeners();
        ActivityButton.onClick.AddListener(() => SaveLoad.SavePlayerStats());
        if (_LoadingScene[i] != 0)
            ActivityButton.onClick.AddListener(() => ActivityButton.GetComponent<SceneLoader>().Loading(_LoadingScene[i]));
        OtherEvent(i);
        if ((PlayerController.ItemPlayerSprite == null) && (i == 5))
        {
            ActivityButton.gameObject.SetActive(false);
        }
        if ((PlayerController.ItemPlayerSprite != null) && (i != 5))
        {
            ActivityButton.gameObject.SetActive(false);
        }
    }

    private void Cheaker()
    {
        for (int i = 0; i <= 7; i++)
        {
            if ((Player.transform.position - MainObjects[i].transform.position).sqrMagnitude < 5)
            {
                _IsNearestObject = true;
                GetClickEvent(i);
                break;
            }
        }
        if (!_IsNearestObject)
            ActivityButton.gameObject.SetActive(false);
        _IsNearestObject = false;
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