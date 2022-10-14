using UnityEngine;

public abstract class IMineral 
{
     protected MineralStock _mineralStock = new MineralStock();
    public abstract int IdMineral { get; }
}
