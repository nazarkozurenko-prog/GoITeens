using System;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class InputManager : MonoBehaviour
{
    public static event Action OnSpacePressed;
    public static event Action<Vector2> OnMovePressed;

    public void OnSpaceCallBack(CallbackContext input)
    {
        if (input.performed)
        {
            OnSpacePressed?.Invoke();
        }
    }

    public void OnMoveCallBack(CallbackContext input)
    {
        Vector2 move = input.ReadValue<Vector2>();

        OnMovePressed?.Invoke(move);
    }
}