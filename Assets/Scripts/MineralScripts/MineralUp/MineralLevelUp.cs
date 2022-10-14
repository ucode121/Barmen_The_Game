using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralLevelUp : MonoBehaviour
{
    public delegate void LvlMineralChanges(ref IMineral mineral, ref Sprite _skin, int Level);
    public static event LvlMineralChanges LevelMineralWasCnages;

    public void UpMineralLevel(ref IMineral mineral , ref Sprite _skin , int Level)
    {
        LevelMineralWasCnages(ref  mineral, ref _skin,  Level);
    }
}
