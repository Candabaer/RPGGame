using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Creatures/Humanoids")]

public class Humanoid : Creature
{
	public Humanoid(string name, int maxLifePoints, int lifePoints,
		Dictionary<ItemSlotTypes, Item> equipment, List<Item> inventory)
		: base(name, maxLifePoints, lifePoints, equipment, inventory)
	{

	}
}

