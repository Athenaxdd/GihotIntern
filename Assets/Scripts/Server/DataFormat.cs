using System;
using UnityEngine;
[Serializable]
public class SendData<T>
{
    public string player_id = Player_ID.MyPlayerID;
    public T _event;
    public SendData(T _event)
    {
        this._event = _event;
    }
}
[System.Serializable]
class ItemPlayerEvent
{
    public string event_name;
    public bool value;
    public string player_id;
    public string host_id;
    public ItemPlayerEvent(string event_name,bool value,string id)
    {
        this.event_name = event_name;
        this.value = value;
        this.host_id = Player_ID.MyPlayerID;
        this.player_id = id;
    }
}
[System.Serializable]
class OnlineLobbyEvent 
{
    public string event_name;
    public bool value;
    public string name;
    public string game_mode;
    public OnlineLobbyEvent(string event_name, bool value, string name = "", string game_mode = "")
    {
        this.event_name = event_name;
        this.value = value;
        this.name = name;
        this.game_mode = game_mode;
    }
}
[System.Serializable]
class PlayerIdEvent
{
    public string event_name;
    public string player_id = Player_ID.MyPlayerID;
    public PlayerIdEvent(string event_name)
    {
        this.event_name = event_name;
    }
}
[System.Serializable]
class EventName
{
    public string event_name;

}

[System.Serializable]
class First_Connect
{
    public string id;
    public string player_name;
}

[System.Serializable]
class Rooms
{
    public Room[] rooms;
}

[System.Serializable]
class SimplePlayerInfo
{
    public string player_id;
    public string player_name;
    public string host_id;
}

[System.Serializable]
class SimplePlayerInfoList
{
    public SimplePlayerInfo[] players;
}

[System.Serializable]
public class Room
{
    public string id;
    public string name;
    public string game_mode;
}

[System.Serializable]
public class CreepSpawnInfo
{
    public int creepTypeInt;
    [field: SerializeField] public Vector3[] spawnPos;
    public float time;
}
