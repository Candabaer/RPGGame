using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Armor")]
public class Armor : Item
{
	[Header("Armor Stats")]
	public int DefenseValue;
	public int Durability;
}
[Serializable]
public class ArmorDTO
{
	public float DefenseValue;
	public int Durability;
	public List<WeaponModifier> modifier;
	public string name;
	public string description;
	public bool dROPABBLE;
	public ItemSlotTypes itemSlotType;
}
