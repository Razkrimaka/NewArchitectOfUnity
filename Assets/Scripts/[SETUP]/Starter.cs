using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RazTools;

public class Starter : MonoBehaviour {


	void Awake () {
        UpdateManager.Instance.Initialise();
        GLogic.Instance.Initialise();
        MapManager.Instance.Initialise();
        NumberManager.Instance.Initialise();
        Controller.Instance.Initialise();
        GVisualise.Instance.Initialise();

    }

}
