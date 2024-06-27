using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField ] List<Button> lsBtnShowPlayer=new List<Button>();
    [SerializeField] private List<GameObject> lsGOPlayer = new List<GameObject>();
    [SerializeField] private GameObject goOnline;
    [SerializeField] public Button btnOnline;
    [SerializeField] private List<GameObject> lsBtnForPlayer = new List<GameObject>();
    [SerializeField] private List<TextMeshProUGUI> lsTxtName = new List<TextMeshProUGUI>();
    [SerializeField] private List<GameObject> goPlayerList = new List<GameObject>();
    [SerializeField] private GameObject prefabItemListPlayer;
    [SerializeField] private GameObject goScrollViewPlayerList;
    public void OnSetUp()
    {
        
        lsBtnForPlayer[0].SetActive(true);
        lsBtnForPlayer[1].SetActive(false);
        goOnline.SetActive(false);
        lsGOPlayer[0].SetActive(false);
        lsGOPlayer[1].SetActive(false);
        goPlayerList[0].SetActive(false);
        goPlayerList[1].SetActive(false);
    }

    public void ShowPlayerBtn()
    {
        lsBtnForPlayer[1].SetActive(true);
        lsBtnForPlayer[0].SetActive(false);
    }

    public void ChangeLobbyListName(Dictionary<string,Player> players)
    {

        for (int i = 0; i < players.Count; i++)
        {
            goPlayerList[i].SetActive(false);
        }
        int index = 1;
        foreach (var pair in players)
        {
            
            if (pair.Key == Player_ID.MyPlayerID)
            {
                lsTxtName[0].text = pair.Value.name;
                goPlayerList[0].SetActive(true);
            }
            else
            {
                lsTxtName[index].text = pair.Value.name;
                goPlayerList[index].SetActive(true);
                index++;
            }
        }
    }
    
    public void AfterCreate()
    {
        btnOnline.gameObject.SetActive(false);
        lsBtnForPlayer[0].SetActive(true);
        lsBtnForPlayer[1].SetActive(false);
        lsGOPlayer[0].SetActive(true);
    }
    public void AfterCreateGuess()
    {
        btnOnline.gameObject.SetActive(false);
        lsBtnForPlayer[1].SetActive(true);
        lsBtnForPlayer[0].SetActive(false);
        lsGOPlayer[0].SetActive(true);
    }
    public void OnBtnClick(int index)
    {
        if (index == 0)
        {
            lsGOPlayer[1].SetActive(true);
            lsGOPlayer[0].SetActive(false);
        }
        else
        {
            lsGOPlayer[0].SetActive(true);
            lsGOPlayer[1].SetActive(false);
        }
    }

    public void OnOnline_Clicked()
    {
        goOnline.SetActive(true);
    }
    
}
