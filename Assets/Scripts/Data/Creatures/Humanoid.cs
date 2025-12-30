using System.Collections.Generic;

public class Humanoid : Creature
{
	public Humanoid(string name, int maxLifePoints, int lifePoints,
		Dictionary<ItemSlotTypes, Item> equipment, List<Item> inventory)
		: base(name, maxLifePoints, lifePoints, equipment, inventory)
	{

	}
}

