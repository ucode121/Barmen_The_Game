using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDehaviorWantLevlUpMineral : MonoBehaviour, IPlayerBehavior
{

     private StateCase _stats = new StateCase();

    public void Enter()
    {
        if (_stats.GetPlayerWantBuyUpForMineralState() == true )
        {
            Debug.Log("Состояние уже установленно");
            return;
        }
        _stats.EnterPlayerWantBuyUpForMineralState();
    }

    public void Exit()
    {
      if(_stats.GetPlayerWantBuyUpForMineralState() == false)
        {
            Debug.Log("Состояние не установлено , из чего ты питаешся выйти?");
            return;
        }
        _stats.ExitPlayerWantBuyUpForMineralState();
    }
}
