using System.Collections.Generic;
using UnityEngine;

public class StockPrayseInfo : MonoBehaviour
{
    public Dictionary<int, int> MineralPrayse = new Dictionary<int, int>()
   {
       {1 , 25},
       {2 , 50}
   };

    public int ReturPrayse(int ID)
    {
       return MineralPrayse[ID];
    }
}
