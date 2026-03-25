using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController
{
    InputActionReference moveAction;

    PlayerMovement _movement;

    public PlayerController(InputActionReference mAction, PlayerMovement mov)
    {
        Debug.Log("PlayerController creado!");
        mAction = moveAction;
        mov = _movement;
    }
    public void UpdateController()
    {
        Vector2 action = moveAction.action.ReadValue<Vector2>();

        Vector3 dir = new Vector3(action.x, 0, action.y);

        _movement.Move(dir);
    }
}