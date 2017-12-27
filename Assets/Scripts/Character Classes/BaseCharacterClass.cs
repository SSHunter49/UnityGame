using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass
{
    // Faction Attributes
    private string faction;
    
    // Character Attributes
    private string name;
    private string bio;
    // Stats 
    private int energy;
    private int endurance;
    private int armor;
    private int intellect;
    private int moral;


    public string CharacterName
    {
        get { return name; }
        set { name = value; }
    }

    public string CharacterBio
    {
        get { return bio; }
        set { bio = value; }
    }

    public int Energy
    {
        get { return energy; }
        set { energy = value; }
    }

    public int Endurance
    {
        get { return endurance; }
        set { endurance = value; }
    }

    public int Armor
    {
        get { return armor; }
        set { armor = value; }
    }

    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }

    public int Moral
    {
        get { return moral; }
        set { moral = value; }
    }

    public string Faction
    {
        get { return faction; }
        set { faction = value; }
    }
}
