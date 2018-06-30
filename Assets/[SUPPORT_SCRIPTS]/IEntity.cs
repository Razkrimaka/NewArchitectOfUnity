using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RazTools;

public abstract class Entity  {
    private int id;


    public int GetID ()
    {
        return id;
    }



    public Entity ()
    {
        id = NumberManager.Instance.GetNumber();       
    }
}
