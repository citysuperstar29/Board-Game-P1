using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//adds a right click window in the unity editor to make a unit.
[CreateAssetMenu(fileName = "New Unit", menuName = "Scriptable Unit")]
public class ScriptableUnit : ScriptableObject
{
    public Faction Faction;
    public BaseUnit UnitPrefab;
}

public enum Faction
{
    Heroes = 0,
    Enemies = 1
}