using UnityEngine;

public class PlayerMovement
{
    float _speed;
    Transform transform;

    public PlayerMovement(Transform t, float s)
    {
        transform = t;
        _speed = s;
    }
    public void Move(Vector3 dir)
    {
        transform.position += dir * _speed * Time.deltaTime;
    }
}
