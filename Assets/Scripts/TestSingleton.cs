using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSingleton : MonoBehaviour {
    private void Awake()
    {
        Debug.Log("Менеджер уже создан?");
        Debug.Log(Manager.Instance.message);
    }
}
