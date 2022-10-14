using System;
using System.Collections.Generic;
using UnityEngine;

public class MineralUpdater : MonoBehaviour
{
    public Many many;

   
    public Sprite[] _skins ;

    public Dictionary<Type, IMineral> MineralCase;


    //public Dictionary<int, int> PrayseUp = new Dictionary<int, int>()
    //{
    //    {0 , 25 }
    //};

    private void Start()
    {
        MineralCase = new Dictionary<Type, IMineral>();
        MineralCase[typeof(Bronz)] = new Iron();
        MineralCase[typeof(Iron)] = new Bronz();
    }
    private Iron iron = new Iron();
    private void OnEnable()
    {
        MineralLevelUp.LevelMineralWasCnages += UpdaitMineral;
    }

    private void OnDisable()
    {
        MineralLevelUp.LevelMineralWasCnages -= UpdaitMineral;
    }
    public void UpdaitMineral(ref IMineral mineral, ref Sprite _skin, int Level)
    {

       //many.MinuseMany(PrayseUp[Level]);
        UpIMineral(ref mineral);
        UpMineralSkin(ref _skin, Level);
    }

    public void UpIMineral(ref IMineral mineral)
    {
        mineral = MineralCase[mineral.GetType()];
    }

    public void UpMineralSkin(ref Sprite _skin , int Level)
    {
        _skin = _skins[Level];
    }
}
