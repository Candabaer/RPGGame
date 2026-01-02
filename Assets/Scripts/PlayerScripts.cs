using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScripts : MonoBehaviour
{
	IMovement _movement;
	PlayerInputHandler _input;
	PlayerCombat _autoAttack;
	public Humanoid Humanoid;

	private void Awake()
	{
		_autoAttack = GetComponent<PlayerCombat>();
		_movement = GetComponent<IMovement>();
		_input = GetComponent<PlayerInputHandler>();
	}

	private void OnEnable()
	{
		_input.OnMove += Move;
		_input.OnAttack += Attack;
	}

	private void Attack(InputAction.CallbackContext context)
	{
		Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
		if (Physics.Raycast(ray, out RaycastHit hit))
		{
			EnemyScripts target = hit.collider.GetComponent<EnemyScripts>();
			Debug.Log("Wir haben auf: " + target.Creature.name + " geklickt!");
			if (target != null)
			{
				_autoAttack.AttackIssued(target.Creature);
			}
		}
	}

	private void OnDisable()
	{
		_input.OnMove -= Move;
		_input.OnAttack -= Attack;
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
