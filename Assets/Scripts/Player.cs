using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public delegate void GetDamage();
    public delegate void GetDamageLife(int life);
    
    //public GetDamage PlayerGetDamage = delegate { }; //para evitar null reference error
    
    public Action PlayerGetDamage;
    public Action<int> PlayerGetDamageLife = delegate { };
    public GetDamageLife PlayerSetDamageLife = delegate { };

    public int MaxLife = 20;
    private int life = 20;
    
    [SerializeField]
    InputActionReference _damageButtonAction;

    private void Awake()
    {
        _damageButtonAction.action.performed += TakeDamageButton;
    }

    #region TakeDamage
    public void TakeDamage(int damage)
    {
        life -= damage;

        PlayerGetDamage?.Invoke(); // Si playergetdamage tiene algo, invoke?
        PlayerGetDamageLife?.Invoke(damage);
    }

    void TakeDamageButton(InputAction.CallbackContext context)
    {
        TakeDamage(1);
    }
    #endregion
}
