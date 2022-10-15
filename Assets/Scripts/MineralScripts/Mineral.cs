using UnityEngine;

public class Mineral : MonoBehaviour
{
    [SerializeField] GameObject _thisMineral;
    [SerializeField] private int _maxMineralLevel;
    private IMineral _mineral;
    private  Sprite _sprite;
    // ��� ���� 2 ���������� ��� _sprite , _thisMineral .
    // ��� �������� ��������� ��� �������� ����� ����� ������ ��� ��������� ������ 
    // �� ������ ������ ��� ��������� ������ ������� ,MineralLevelUp.UpMineralLevel();
    // ���� ����� �������� �� �� ����� ���������� ������� ��������, �� �������� ���� ��������
    // ��� ��������� ���� �������� ��� ����� ����� ��� ����� ���� �������� � �����  
    //������ �� ������� ������ �������� ������� ��� ��������� ���� � ����� ��������
    //��� ���� ������ 

    // ����� ����� ���������� ����� ������ ������� �� ���� ���� ������ ���� ���� Bronz � ������ �������� � Iron
    // ���� ������� � 

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
            Debug.Log("�� �������� ������������� ������");
            return;
        }

        _levelMineral += 1;

        _thisMineral.GetComponent<SpriteRenderer>().sprite = _sprite;
    }


}
