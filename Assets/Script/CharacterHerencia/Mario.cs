using UnityEngine;

public class Mario : Character
{
    public override void SpecialAttack()
    {
        Debug.Log($"<color = red>Mario {gameObject.name} performs a super jump!</color>");
    }
}
