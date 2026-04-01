using UnityEngine;

public class Sonic : Character
{
    public override void SpecialAttack()
    {
        Debug.Log($"<color = blue>Sonic {gameObject.name} performs a spin attack!</color>");
    }
}
