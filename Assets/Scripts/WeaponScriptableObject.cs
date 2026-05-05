using UnityEngine;
[CreateAssetMenu(fileName = "WeaponScriptableObject", menuName = "ScriptableObjects/Weapon")]

public class WeaponScriptableObject : ScriptableObject
{
    public GameObject prefab;
    //Base stats for weapons
    public float damage;
    public float speed;
    public float cooldownDuration;
    public int pierce;
}
