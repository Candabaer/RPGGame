using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerInputHandler : MonoBehaviour
{
	[SerializeField] private InputAction clickAction;

	public event Action<InputAction.CallbackContext> OnMove;

	private void OnEnable()
	{
		clickAction.performed += HandleMove;
		clickAction.Enable();
	}

	private void OnDisable()
	{
		clickAction.performed -= HandleMove;
		clickAction.Disable();
	}

	private void HandleMove(InputAction.CallbackContext context)
	{
		OnMove?.Invoke(context);
	}
}
