using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHumanClass : BaseCharacterClass
{

    public BaseHumanClass()
    {
        Faction = "Ares";
        CharacterName = "Mankind";
        CharacterBio = @"A species created in the image of God,";

        Energy = 75;
        Endurance = 45;
        Intellect = 85;
    }
}
