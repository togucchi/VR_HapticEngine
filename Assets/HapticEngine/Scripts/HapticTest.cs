using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);

		 if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
        {
            GetComponent<HapticSource>().Play();
        }
	}
}
