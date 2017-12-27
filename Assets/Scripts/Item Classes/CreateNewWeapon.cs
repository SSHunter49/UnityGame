using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CreateNewWeapon : MonoBehaviour {

    private BaseItem newWeapon;

    private List<string> shotgunNames = new List<string> { "Mossberg 500", "Remington Model 870"};



    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();

        // Assign Item Type
        newWeapon.ItemType = BaseItem.ItemTypes_E.WEAPON;

        // Assign Item ID
        newWeapon.ItemId = UnityEngine.Random.Range(0, 500);

        // Assign Item Name
        newWeapon.ItemName = newWeapon.ItemType + "_" + newWeapon.ItemId.ToString();

        // Assign Item Description
        newWeapon.ItemDescription = "Create a desc. after randomly selecting a weapon to create.";

        // Assign Item Class
        // 50% - COMMON
        // 25% - UNCOMMON
        // 15% - RARE
        // 10% - EXOTIC

        int randValue = UnityEngine.Random.Range(0, 100);
        if (randValue <= 55)
        {
            newWeapon.ItemClass = BaseItem.ItemClass_E.COMMON;
        } else if (randValue > 50 && randValue <= 75)
        {
            newWeapon.ItemClass = BaseItem.ItemClass_E.UNCOMMON;
        } else if (randValue > 75 && randValue <= 90)
        {
            newWeapon.ItemClass = BaseItem.ItemClass_E.RARE;
        } else if (randValue > 90 && randValue <=100)
        {
            newWeapon.ItemClass = BaseItem.ItemClass_E.EXOTIC;
        }

        // Assign Weapon Type
        Array values = Enum.GetValues(typeof(BaseWeapon.WeaponTypes_E));
        System.Random random = new System.Random();
        BaseWeapon.WeaponTypes_E weaponType = (BaseWeapon.WeaponTypes_E)values.GetValue(random.Next(values.Length));


        // Assign Weapon Damage


        // Assign Weapon EffectiveRange


    }
}
