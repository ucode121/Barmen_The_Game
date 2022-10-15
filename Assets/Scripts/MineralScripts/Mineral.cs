using UnityEngine;

public class Mineral : MonoBehaviour
{
    [SerializeField] GameObject _thisMineral;
    [SerializeField] private int _maxMineralLevel;
    private IMineral _mineral;
    private  Sprite _sprite;
    // “ут есть 2 переменные это _sprite , _thisMineral .
    // ќни €вл€ютс€ заглушкой дл€ мешаники смены скина обекта при повышении уровн€ 
    // Ќа данный момент при повышении уровн€ минерал ,MineralLevelUp.UpMineralLevel();
    // этот метод отвечает за то чтобы поднималс€ уровень минерала, не мин€етс€ скин минерала
    // ѕри написании кода учитывай что нужно чтобы его можно было редачить с юнити  
    //ѕрехаб на который должен мен€тьс€ минерал при повышении есть в папке префабов
    //Ёто тво€ задача 

    // “акже нужно протестить смену самого ресурса то есть руда раньше была типа Bronz а сейчас перейшла в Iron
    // етим займусь € 

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
        print(1);
        if (_levelMineral == _maxMineralLevel)
        {
            Debug.Log("¬ы достигли максимального левела");
            return;
        }

        _levelMineral += 1;

        _thisMineral.GetComponent<SpriteRenderer>().sprite = _sprite;
    }


}
