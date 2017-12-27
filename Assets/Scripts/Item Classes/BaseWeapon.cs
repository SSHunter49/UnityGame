using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Base Weapon <- BaseStatItem <- BaseItem
public class BaseWeapon : BaseStatItem {

    public enum WeaponTypes_E
    {
        SHOTGUN,
        SUB_MACHINE_GUN,
        LIGHT_MACHINE_GUN,
        SNIPER,
        HAND_GUN
    }

    private WeaponTypes_E weaponType;
    private int damage; // HP
    private int effectiveRange; // meters
    private int muzzleVelocity; // meters/second


    // Getters and setters
    public WeaponTypes_E WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }

    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }

    public int EffectiveRange
    {
        get { return effectiveRange; }
        set { effectiveRange = value; }
    }

    public int MuzzleVelocity
    {
        get { return muzzleVelocity; }
        set { muzzleVelocity = value; }
    }

}
