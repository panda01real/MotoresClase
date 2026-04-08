using UnityEngine;

public abstract class DestroyableItem : MonoBehaviour
{
    protected abstract void DestroyEffect();

    public void DestroyItem()
    {
        DestroyEffect();

        Debug.Log($"<color=red>Se Destruyo {this.name}");

        Destroy(gameObject);
    }
}