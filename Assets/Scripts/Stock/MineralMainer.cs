using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralMainer : MonoBehaviour
{
    public delegate void MineralIsMain(IMineral mineral);
    public static event MineralIsMain MineralMain;

    public void StartMainingIvent(IMineral mineral)
    {
        MineralMain(mineral);
    }
}
