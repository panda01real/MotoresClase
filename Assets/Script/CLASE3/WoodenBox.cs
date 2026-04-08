using UnityEngine;

public class WoodenBox : DestroyableItem, IBurnableItem
{
    public void BurnItem()
    {
        Debug.Log("Burn");
    }
    protected override void DestroyEffect()
    {

    }
}
