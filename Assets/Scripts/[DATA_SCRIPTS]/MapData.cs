using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RazTools
{
    [CreateAssetMenu(fileName ="MapData", menuName = "RazTools/MapData")]
    public class MapData : ScriptableObject
    {
        [SerializeField]
        int MapX;

        [SerializeField]
        int MapY;
    }
}
