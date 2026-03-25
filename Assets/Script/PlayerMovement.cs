using UnityEngine;

public class PlayerMovement
{
    float _speed;
    Transform transform;

    public PlayerMovement(Transform t, float s)
    {
        t = transform;
        s = _speed;
    }
    public void Move(Vector3 dir)
    {
        transform.position += dir * _speed * Time.deltaTime;
    }
}
