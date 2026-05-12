using UnityEngine;

public class Player : MonoBehaviour
{
    /*     /--------------------------------------\
     *     |@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|
     *     |   D E L E G A T E S & E V E N T S    |
     *     |@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@|
     *     \--------------------------------------/
     *
     */

    public delegate void GetDamage();
    
    public GetDamage PlayerGetDamage;
    
    private int _life;

    void TakeDamage(int damage)
    {
        _life -= damage;
        
        PlayerGetDamage?.Invoke();
    }
}