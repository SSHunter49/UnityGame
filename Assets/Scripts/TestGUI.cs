using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour
{

    private BaseCharacterClass class1 = new BaseHumanClass();
    private BaseCharacterClass class2 = new BaseAlienClass();
    private BaseCharacterClass class3 = new BaseRobotClass();


    private void OnGUI()
    {
        GUILayout.Label(class1.CharacterName);
        GUILayout.Label(class1.CharacterBio);
        GUILayout.Label(class2.CharacterName);
        GUILayout.Label(class2.CharacterBio);
        GUILayout.Label(class3.CharacterName);
        GUILayout.Label(class3.CharacterBio);
    }
}
