using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RazTools;

public class Starter : MonoBehaviour {


	void Awake () {
        GLogic.Instance.Initialise();
        GVisualise.Instance.Initialise();
        MapManager.Instance.Initialise();
        NumberManager.Instance.Initialise();
        Controller.Instance.Initialise();

	}

}
