using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RazTools {
    public class MapManager : Singleton<MapManager> {
        private Dictionary<IntVector2, MapCell> _mapCells = new Dictionary<IntVector2, MapCell>();

        public override void Initialise()
        {

        }
    }
}
