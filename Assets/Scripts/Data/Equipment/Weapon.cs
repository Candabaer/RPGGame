using System;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Items/Weapons")]

public class Weapon : Item
{
	[Header("Weapon Stats")]
	public int DamageValue;
	public float AttackRange;
	public float AttackSpeed;
	public List<WeaponModifier> Modifier;
}
[Serializable]
public class WeaponDTO
{
	public float AttackSpeed;
	public int DamageValue;
	public List<WeaponModifier> Modifier;
	public string Name;
	public string Description;
	public bool DROPABBLE;
	public ItemSlotTypes ItemSlotType;
}
