using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatItem : BaseItem {

    private int energy;
    private int endurance;
    private int intellect;

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

    public int Intellect
    {
        get { return intellect; }
        set { intellect = value; }
    }

}
