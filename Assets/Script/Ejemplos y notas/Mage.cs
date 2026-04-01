using UnityEngine;

public class Mage : MonoBehaviour
{
    private int _life = 100;
    //private int _mana = 100;

    public int _damage = 10;

    void CastMagic()
    {
        Debug.Log($"<color = yellow>Mage {gameObject.name} casts a spell dealing {_damage} damage.</color>");
    }

    public void TakeDamage(int damage)
    {
        _life -= damage;
        if (_life <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log($"Mage {gameObject.name} has died.");
        // Additional logic for death can be added here (e.g., play animation, disable character, etc.)

        Destroy(gameObject); // Remove the mage from the scene
    }
}