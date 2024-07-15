using UnityEngine;

[CreateAssetMenu(fileName = "PlayerConfig", menuName = "Config/PlayerConfig")]
public class PlayerConfig : ScriptableObject
{
    public SkillType skillType;

    public float speed;

    public GameObject levelUpEffect;
}
public enum SkillType
{
    Tank,
    DPS,
    Heal,
}