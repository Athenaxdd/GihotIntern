using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevelUp : MonoBehaviour
{
    [SerializeField] private List<ItemLevelUp> lsItemLevel;
    public void OnSetUp(List<string> lsLevelUp)
    {
        int i = 0;
        this.gameObject.SetActive(true);
        foreach (var buff in lsItemLevel)
        {
            buff.OnChangeInfo(lsLevelUp[i]);
            i++;
        }
    }

    public void OnItemLevelUp_Clicked(int index)
    {
        UIManager._instance.PlaySfx(0);
        //TODO Hung
        // AllLevelUpConfig allLevelUpConfig = AllManager.Instance().playerManager.allLevelUpConfig;
        LevelUpConfig levelUpConfig = AllManager.Instance().playerManager.levelUpConfig;
        
        levelUpConfig.ApplyBaseStat(lsItemLevel[index].txtName.text);
        //this.gameObject.SetActive(false);
        //TODO sent Chosed Tung
        
        SendData<ChooseLevelUpEvent> data = new SendData<ChooseLevelUpEvent>(new ChooseLevelUpEvent());
        SocketCommunication.GetInstance().Send(JsonUtility.ToJson(data));
        
        Destroy(this.gameObject);
       // UIManager._instance.lsLevelUp.RemoveAt(UIManager._instance.lsLevelUp.Count);
    }
}
