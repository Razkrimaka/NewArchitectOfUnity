using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : Singleton<Manager>
{

    public string message = "Да, я уже создан";


    private void Awake()
    {
        Debug.Log("[Menager]: Мой тип = " + Instance.GetType().ToString());
    }
}
