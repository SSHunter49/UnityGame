using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAlienClass : BaseCharacterClass {

    public BaseAlienClass()
    {
        Faction = "Vandarian";
        CharacterName = "Vandalier";
        CharacterBio = @"A unknown species discovered on the planet of Ragnous;";

        Energy = 40;
        Endurance = 50;
        Intellect = 28;
    }
}
