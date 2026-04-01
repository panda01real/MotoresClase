using UnityEngine;

public class Zelda : Character  
{
    public override void SpecialAttack()
    {
        Debug.Log($"<color = magenta>Zelda {gameObject.name} performs a magic attack!</color>");
    }
}
