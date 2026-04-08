using UnityEngine;
[RequireComponent (typeof(Rigidbody))]
public class Sword : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        DestroyableItem item = collision.gameObject.GetComponent<DestroyableItem>();

        if (item != null)
        {
            item.DestroyItem();
        }
    }
}
