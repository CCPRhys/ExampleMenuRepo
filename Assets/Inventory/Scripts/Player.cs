using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private CharacterController cc;

    private Vector2 lastMovementInput;

    // Update is called once per frame
    void Update()
    {
        if(cc != null)
        {
            cc.Move(lastMovementInput * Time.deltaTime);
        }
    }

    public void MovementInput(InputAction.CallbackContext context)
    {
        lastMovementInput = context.ReadValue<Vector2>();
    }

}
