using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem
{
    private string itemName;
    private string itemDescription;
    private int itemLevel;
    private int itemId;

    public enum ItemClass_E
    {
        COMMON,
        UNCOMMON,
        RARE,
        EXOTIC
    }

    public enum ItemTypes_E
    {
        EQUIPMENT,
        WEAPON,
        WEAPON_MODIFIER,
        AMMUNITION,
        NURISHMENT,
        MEDICAL
    }

    private ItemTypes_E itemType;
    private ItemClass_E itemClass;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }
    }

    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }

    public ItemClass_E ItemClass
    {
        get { return itemClass; }
        set { itemClass = value; }
    }
    public int ItemId
    {
        get { return itemId; }
        set { itemId = value; }
    }

    public ItemTypes_E ItemType
    {
        get { return itemType; }
        set { itemType = value; }
    }
}
