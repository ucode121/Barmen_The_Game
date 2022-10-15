using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateCase : IBuyState
{
    private bool PlayerWantBuyUpForMineral = true ;

    public void EnterPlayerWantBuyUpForMineralState()
    {
        PlayerWantBuyUpForMineral = true;
    }

    public void ExitPlayerWantBuyUpForMineralState()
    {
        PlayerWantBuyUpForMineral = false; 
    }

    public bool GetPlayerWantBuyUpForMineralState ()
    {
        return PlayerWantBuyUpForMineral;
    }
}
