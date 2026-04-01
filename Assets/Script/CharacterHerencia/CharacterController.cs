using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
   [SerializeField] public Character character;

   public InputActionReference action;

    private void Update()
    {
        if (action.action.WasPerformedThisFrame())
        {
            character.SpecialAttack();
        }
    }
}
