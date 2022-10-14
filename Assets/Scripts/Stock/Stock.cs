using System.Collections;
using UnityEngine;

public class Stock : MonoBehaviour
{
    [SerializeField] private GameObject _stockMineralPrefab;
    [SerializeField] private Many _manyCase;
    [SerializeField] private int _timeBeforSell;

    private StockPrayseInfo _stockPrayseInfo;
    private MineralStock _mineralStock = new MineralStock();
  
    private void Start()
    {
        _stockPrayseInfo = _stockMineralPrefab.GetComponent<StockPrayseInfo>();
        StartCoroutine(SellAll());
    }
    private void OnEnable()
    {
        MineralMainer.MineralMain += StockSortMineral;
    }

    private void OnDisable()
    {
        MineralMainer.MineralMain -= StockSortMineral;
    }

    public void StockSortMineral(IMineral _mineral)
    {
       _mineralStock.AddNewMineral(_mineral.IdMineral);
    }

    public IEnumerator SellAll()
    {
        yield return new WaitForSeconds(_timeBeforSell);
        SellAllMineral();
        ReturnCarytine();
       
    }

    public void ReturnCarytine()
    {
        StartCoroutine(SellAll());
    }

    public void SellAllMineral()
    {
        for (int i = 0; i < _mineralStock.AllMineralsId.Count; i++)
        {
            int MineraPreyse = _stockPrayseInfo.ReturPrayse(_mineralStock.AllMineralsId[i]);
            Debug.Log(MineraPreyse);
            int HowManyMineral = _mineralStock.mineralStock[_mineralStock.AllMineralsId[i]];
            Debug.Log(HowManyMineral);
            _manyCase.AddMany(HowManyMineral * MineraPreyse);
            _mineralStock.SetZiroy(_mineralStock.AllMineralsId[i]);
        }
    }
}
