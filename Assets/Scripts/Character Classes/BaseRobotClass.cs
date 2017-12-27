using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseRobotClass : BaseCharacterClass
{ 

    public BaseRobotClass()
    {
        Faction = "Synthisen";
        CharacterName = "Scout";
        CharacterBio = @"A danagerous self-learning AI created by mankind, harnessing all of their intellect and none of their morality";

        Energy = 50;
        Endurance = 80;
        Intellect = 75;

    }


}
