using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerInputHandler : MonoBehaviour
{
	[SerializeField] private InputAction clickAction;
	[SerializeField] private InputAction attackAction;

	public event Action<InputAction.CallbackContext> OnMove;
	public event Action<InputAction.CallbackContext> OnAttack;

	private void OnEnable()
	{
		attackAction.performed += Attack;
		clickAction.performed += HandleMove;
		clickAction.Enable();
		attackAction.Enable();
	}

	private void OnDisable()
	{
		attackAction.performed -= Attack;
		clickAction.performed -= HandleMove;
		clickAction.Disable();
		attackAction.Disable();
	}

	private void Attack(InputAction.CallbackContext context)
	{
		OnAttack?.Invoke(context);
	}

	private void HandleMove(InputAction.CallbackContext context)
	{
		OnMove?.Invoke(context);
	}
}
