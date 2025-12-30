using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ItemFactory
{
	string weaponPath = "Assets/JSONFiles/Weapon.json";

	public List<WeaponDTO> CreateWeapons()
	{
		string jsonString = File.ReadAllText(weaponPath);
		List<WeaponDTO> result = JsonUtility.FromJson<List <WeaponDTO>>(jsonString)!;
		return result;
	}

}

