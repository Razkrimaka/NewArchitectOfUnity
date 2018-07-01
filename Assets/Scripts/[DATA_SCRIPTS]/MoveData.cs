using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RazTools;

[CreateAssetMenu(fileName = "MoveData", menuName = "RazTools/MoveData")]
public class MoveData : ScriptableObject {
    [SerializeField]
    public float speed;
}
