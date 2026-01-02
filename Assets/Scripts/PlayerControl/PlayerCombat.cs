using System.Collections;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
	public Weapon Weapons;
	private Coroutine attackRoutine;
	public bool isAttacking = false;
	private Creature currentTarget;

	public void AttackIssued(Creature target)
	{
		if (isAttacking || target == null)
			return;

		SetTarget(target);
		attackRoutine = StartCoroutine(AutoAttack());
	}

	private void SetTarget(Creature target)
	{
		if (currentTarget != null)
			currentTarget.OnDeath -= OnTargetDeath;

		currentTarget = target;
		currentTarget.OnDeath += OnTargetDeath;
	}

	private void OnTargetDeath()
	{
		AttackStopped();
		SearchNextTarget();
	}

	private IEnumerator AutoAttack()
	{
		isAttacking = true;

		while (isAttacking)
		{
			PerformAttack();
			yield return new WaitForSeconds(Weapons.AttackSpeed);
		}
	}

	private void PerformAttack()
	{
		if (currentTarget == null)
			return;

		Debug.Log("Before Damage: " + currentTarget.LifePoints);
		currentTarget.ApplyDamage(Weapons.DamageValue);
		if (currentTarget != null)
			Debug.Log("After Damage: " + currentTarget.LifePoints);

	}

	private void AttackStopped()
	{
		isAttacking = false;
		if (attackRoutine != null)
		{
			StopCoroutine(attackRoutine);
			attackRoutine = null;
		}
		if (currentTarget != null)
		{
			currentTarget.OnDeath -= OnTargetDeath;
			currentTarget = null;
		}
	}

	private void SearchNextTarget()
	{
		//TODO 
	}
}
