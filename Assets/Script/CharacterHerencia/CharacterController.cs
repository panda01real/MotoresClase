using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
   public Character character;

   public InputActionReference action;

    private void Update()
    {
        if (action.action.WasPerformedThisFrame())
        {
            character.SpecialAttack();
        }
    }
}
