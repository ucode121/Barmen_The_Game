using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mineral : MonoBehaviour
{
    [SerializeField] private int _maxMineralLevel;
    private IMineral _mineral;
    [SerializeField] GameObject _thisMineral;
    private  Sprite _sprite;
    

    private IBuyState _buyState;
    private int _levelMineral;
    
    
    public MineralLevelUp MineralLevelUp;
    public MineralMainer MineralMainer;

    private void Start()
    {
        _buyState = new StateCase();
        _mineral = new Bronz();
        
    }

    private void OnMouseDown()
    {
        if (_buyState.GetPlayerWantBuyUpForMineralState() == true)
        {
            LevelUp();
            MineralLevelUp.UpMineralLevel(ref _mineral, ref _sprite, _levelMineral);           
            return;
        }

         MineralMainer.StartMainingIvent(_mineral);

    }

    public void LevelUp()
    {
        if (_levelMineral == _maxMineralLevel)
        {
            Debug.Log("Вы достигли максимального левела");
            return;
        }

        _levelMineral += 1;   
    }


}
