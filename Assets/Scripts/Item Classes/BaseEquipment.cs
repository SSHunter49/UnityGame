using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEquipment : BaseStatItem
{
    // Equipments provide modifiers to a player's:
    // - Energy,
    // - Armor,
    // - Tech,
    // - Damage

    /*
     * For example, a new gun holster may provide a character with 
     * -5  energy,
     * +15 armor, 
     * +10 tech, 
     * +0  damage 
     */

    public enum EquipmentTypes_E
    {
        ET_BODY_ARMOR,
        ET_HEAD_ARMOR,
        ET_BACKPACK,
        ET_SHOES,
        ET_KNEEPADS,
        ET_HOLSTER,
        ET_AMMO_POUCH,
        ET_NECKLACE
    }

    private EquipmentTypes_E equipmentType;

    public EquipmentTypes_E EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }

}
