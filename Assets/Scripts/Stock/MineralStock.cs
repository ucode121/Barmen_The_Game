using System.Collections.Generic;
using UnityEngine;

public class MineralStock 
{
    public List<int> AllMineralsId { get; private set; } = new List<int>() { 1 };
    public Dictionary<int, int> mineralStock { get; private set; } = new Dictionary<int, int>()
    {
        {1 , 0 },
        {2 , 0 }
    };

    public void AddNewMineral(int ID )
    {   
        mineralStock[ID] += 1;
    }
    
    public void CollectionMineralId(int MineralId)
    {
        for (int i = 0; i < AllMineralsId.Count; i++)
        {          
            if (AllMineralsId[i] == MineralId)
            {
                return;
            }
        }
        AllMineralsId.Add(MineralId);  
    }
    public void SetZiroy(int ID)
    {
        
        mineralStock[ID] = 0;
    }
}
