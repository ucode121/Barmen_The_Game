using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bronz : IMineral
{
    public Bronz()
    {
        _mineralStock.CollectionMineralId(IdMineral);
    }
    public override int IdMineral { get { return 1; } }
}
