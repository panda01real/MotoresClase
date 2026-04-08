using System.Reflection;
using UnityEngine;
[RequireComponent (typeof(Rigidbody))]

public class FireBall : MonoBehaviour
{
    private void Awake()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        IBurnableItem item = collision.gameObject.GetComponent<IBurnableItem>();

        if (item != null)
        {
            item.BurnItem();
        }
    }
}
