using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class HapticListener : MonoBehaviour {
	SteamVR_TrackedObject trackedObject;

	HapticClip currentClip = null;
	bool playing = false;
	float currentTime = 0;
	// Use this for initialization
	void Start () {
		if(trackedObject == null && GetComponent<SteamVR_TrackedObject>())
			trackedObject = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void Update () {
		if(playing)
		{
			if(currentTime >= currentClip.length)
			{
				if(!currentClip.loop)
				{
					playing = false;
					currentClip = null;
					currentTime = 0;
					return;
				}
				else
				{
					currentTime = 0;
				}
				
			}
			int pulse = currentClip.GetValueFromCurve(currentTime);
		//	Debug.Log(currentTime);
			TriggetHapticPulse(pulse);
			currentTime += Time.deltaTime;
		}
	}

	public void Play(HapticClip clip)
	{
		currentTime = 0;
		playing = true;
		currentClip = clip;
	}

	void TriggetHapticPulse(int pulse)
	{
		var device = SteamVR_Controller.Input((int)trackedObject.index);
		device.TriggerHapticPulse((ushort)pulse);
	}
}
