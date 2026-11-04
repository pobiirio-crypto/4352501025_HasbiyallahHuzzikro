using UnityEngine;
using UnityEngine.InputSystem;

public class InputSystemMoveInput : IMoveInput
{
    private readonly InputAction move;
    private readonly InputAction sprint;

    public InputSystemMoveInput()
    {
        move = InputSystem.actions.FindAction("Move");
        sprint = InputSystem.actions.FindAction("Sprint");
    }

    public bool IsRunning => sprint != null && sprint.IsPressed();
    public Vector2 Move => move.ReadValue<Vector2>();
}