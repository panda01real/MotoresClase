using UnityEngine;

public class FireMage : Mage
{
    public Mage Mage;

    public virtual void CastMagic()
    {
        Debug.Log($"<color = red>FireMage {gameObject.name} casts a fireball dealing {_damage * 2} damage.</color>");
    }

    public virtual void TakeDamage()
    {

    }
}
