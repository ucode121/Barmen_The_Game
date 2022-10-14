using System.Collections.Generic;
using UnityEngine;

public class StockPrayseInfo : MonoBehaviour
{
    public Dictionary<int, int> MineralPrayse = new Dictionary<int, int>()
   {
       {1 , 1},
       {2 , 1}
   };

    public int ReturPrayse(int ID)
    {
       return MineralPrayse[ID];
    }
}
