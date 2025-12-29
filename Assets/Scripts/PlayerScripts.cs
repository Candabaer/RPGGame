using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScripts : MonoBehaviour
{
	IMovement _movement;
	PlayerInputHandler _input;

	private void Awake()
	{
		_movement = GetComponent<IMovement>();
		_input = GetComponent<PlayerInputHandler>();
	}

	private void OnEnable()
	{
		_input.OnMove += Move;
	}

	private void OnDisable()
	{
		_input.OnMove -= Move;
	}

	private void Move(InputAction.CallbackContext context)
	{
		var mousePosition = context.ReadValue<Vector2>();
		Ray ray = Camera.main.ScreenPointToRay(mousePosition);

		if (Physics.Raycast(ray, out RaycastHit hit))
		{
			_movement.Move(hit.point);
		}
	}
}
