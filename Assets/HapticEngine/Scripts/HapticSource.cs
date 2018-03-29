using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticSource : MonoBehaviour {
	[SerializeField]
	HapticClip clip;
	[SerializeField]
	HapticListener listener;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Play()
	{
		listener.Play(clip);
	}

	public void Play(HapticListener hapticListener)
	{
		hapticListener.Play(clip);
	}

	public void Play(HapticListener hapticListener, HapticClip hapticClip)
	{
		hapticListener.Play(hapticClip);
	}
}
