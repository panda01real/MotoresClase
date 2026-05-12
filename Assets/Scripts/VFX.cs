using System;
using UnityEngine;

public class VFX : MonoBehaviour
{
    [SerializeField] Player player;

    private void Awake()
    {
        player.PlayerGetDamage += Particles; //suscripcion al delegate
    }

    void Particles()
    {
        Debug.Log("Particulas daño");
    }
}
