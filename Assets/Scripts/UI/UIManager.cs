using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public UIPause uiPause;
    public UIGamePlay uiGameplay;
    public UIOnlineLobby uiOnlineLobby;
    public UIMainMenu uiMainMenu;
    public UILogin uiLogin;
    public UIChoseGun uiChoseGun;
    public FixedJoystick _joystick;
    public FloatingJoystick _fjoystick;
    public static UIManager _instance { get; private set; }


    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    private void Awake()
    {
        _joystick.gameObject.SetActive(false);
        _fjoystick.gameObject.SetActive(false);
        uiOnlineLobby.OnSetUp();
        uiMainMenu.OnSetUp();
        uiChoseGun.OnSetUp();
        uiLogin.OnSetUp();
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            GameObject.Destroy(this.gameObject);
        }
            //new

        }

        private void Update()
    {
        // Debug.Log(Player_ID.MyPlayerID);
    }

    public void OnClose_Clicked()
    {
        this.gameObject.SetActive(false);
    }
}