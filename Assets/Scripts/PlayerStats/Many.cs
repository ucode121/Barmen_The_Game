using UnityEngine;

public class Many : MonoBehaviour
{
    public delegate void ManyIsChange();
    public static event ManyIsChange ManyChange;

    public int Money { get; private set; }

    private void OnEnable()
    {
      Money = PlayerPrefs.GetInt("Money");
    }
    private void OnDisable()
    {
        PlayerPrefs.SetInt("Money", Money);
    }
    public void AddMany(int money)
    {
        if (money <= 0) return; 
        Money += money;
        ManyChange();
    }

    public void MinuseMany(int many)
    {
        if(many >= 0) return;
        Money -= many;
        ManyChange();
    }
}
