using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : IMineral
{
    public Iron()
    {
        _mineralStock.CollectionMineralId(IdMineral);
    }
    public override int IdMineral { get { return 2; } }
}
    

