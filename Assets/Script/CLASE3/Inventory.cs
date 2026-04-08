using System;
using UnityEngine;

public class INventory : MonoBehaviour
{
    public Weapon weapon;
    private void Start()
    {
        weapon = Weapon.Sword;
    }
    public void EquipWeapon(Weapon a)
    {
        weapon = a;
    }

    public void UseArmor(Weapon a)
    {
        switch (weapon)
        {
            case Weapon.Sword:
                break;
            case Weapon.Mace:
                break;
            case Weapon.Spear:
                break;
        }
    }
}