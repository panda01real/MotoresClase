using System;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    [SerializeField]
    Player _player;

    [SerializeField]
    Image _bar;

    private void Awake()
    {
        _player.PlayerGetDamageLife += UpdateLifeBar;
    }

    void UpdateLifeBar(int life)
    {
        float maxLife = _player.MaxLife;
        _bar.fillAmount = (float)life / maxLife;
    }
}
