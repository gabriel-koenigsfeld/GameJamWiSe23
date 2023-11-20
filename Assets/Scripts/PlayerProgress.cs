using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerProgress", menuName = "ScriptableObjects/Progress", order = 1)]
public class PlayerProgress : ScriptableObject
{
    public int level;
    public int rage = 150;
    public TimeState timeState;
    public int day;
}