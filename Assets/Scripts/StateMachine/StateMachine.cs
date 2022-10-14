using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private Dictionary<Type, IPlayerBehavior> _behaviorsMap;
    private IPlayerBehavior _toDayState;

    private void Start()
    {
        
    }

    public void InitBehavior()
    {
        _behaviorsMap = new Dictionary<Type, IPlayerBehavior>();

        _behaviorsMap[typeof(PlayerDehaviorWantLevlUpMineral)] = new PlayerDehaviorWantLevlUpMineral();
    }
    public void SetBehavior(IPlayerBehavior NewPlayerBehavior)
    {
        if (_toDayState != null)
        _toDayState.Exit();

        _toDayState = NewPlayerBehavior;
        _toDayState.Enter();
    }
     
    public void ActiveBahavior()
    {
        if (_toDayState != null)
            _toDayState.Exit();

        _toDayState = GetPlayerBehavior<PlayerDehaviorWantLevlUpMineral>();

        _toDayState.Enter();
    }

    public void ExitFromBehavior()
    {
        if (_toDayState != null)
        {
            Debug.Log("—ейчас игрок не находитс€ не в каком состо€нии!");
            return;
        }

        _toDayState?.Exit();          
    }

    private IPlayerBehavior GetPlayerBehavior<T>() where T : IPlayerBehavior
    {
        var type = typeof(T);
        return _behaviorsMap[type];
    }

    private void SetBehaviorByDefoult()
    {

    }

}
