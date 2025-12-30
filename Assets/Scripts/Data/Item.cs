using System;
using UnityEngine;

public enum ItemSlotTypes
{
	Head, Left_Arm, Right_Arm, Chest, Legs, Boots, Two_Handed
}

public abstract class Item : ScriptableObject
{
	[SerializeField, Header("Base Info")]
	public string Name;
	[SerializeField, TextArea]
	public string Description;
	[SerializeField]
	public bool DROPABBLE;
	[SerializeField]
	public ItemSlotTypes ItemSlotType;
	[SerializeField]
	public Sprite Sprite;
}

