using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Image bar;

    private void UpdateLifeBar(float life,  float maxLife)
    {
        bar.fillAmount = life / maxLife;
    }
}
