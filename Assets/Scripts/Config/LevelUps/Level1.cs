using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Config/LevelUpConfig/Level1")]
public class Level1 : LevelUpConfig
{
    public override int[] getHealthIncrements() { return new int[] { 100, 200, 300 }; }
    public override float[] getSpeedIncrements() { return new float[] { 100f, 100f, 100f }; }
    public override float[] getDamageIncrements() { return new float[] { 100f, 200f }; }
    public override float[] getCritRateIncrements() { return new float[] { 0.03f, 0.06f}; }
    public override float[] getCritDamageIncrements() { return new float[] { 0.06f, 0.12f}; }
    public Level1()
    {
        additionalOptions.Add("Test1");
        additionalOptions.Add("Test2");
    }
    public override void ApplyAdditional(string buff)
    {
        Debug.Log("ApplyAdditional level1");
        base.ApplyAdditional(buff);
        switch (buff)
        {
            case "Test1":
                Debug.Log("Test1");
                break;
            case "Test2":
                Debug.Log("Test2");
                break;
            default:
                break;
        }
    }
}
