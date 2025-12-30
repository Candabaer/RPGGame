using System;
using System.Collections.Generic;

public abstract class Creature
{
	public int LifePoints;
	public int MaxLifePoints;
	public Dictionary<ItemSlotTypes, Item> Equipment;
	public List<Item> Inventory;
	public string Name;

	protected Creature(string name, int maxLifePoints, int lifePoints,
		Dictionary<ItemSlotTypes, Item> equipment, List<Item> inventory)
	{
		Name = name;
		MaxLifePoints = maxLifePoints;
		LifePoints = lifePoints;
		Equipment = equipment;
		Inventory = inventory;
	}

	public event Action OnDeath;

	public void ApplyDamage(int damage)
	{
		LifePoints -= damage;
		if (LifePoints < 0)
		{
			OnDeath?.Invoke();
		}
	}
}