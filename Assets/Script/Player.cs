using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    /*void Shoot()
    {
        Bullet bulletInstance = new Bullet();

        bulletInstance.Explode();
    }*/
    [SerializeField] float _speed = 15.0f;
    [SerializeField] InputActionReference moveAction;

    PlayerController _controller;
    PlayerMovement _movement;

    private void Awake()
    {
        _movement = new PlayerMovement(transform, _speed);
        _controller = new PlayerController(moveAction, _movement);
    }
    private void Update()
    {
        _controller.UpdateController();
    }
}
