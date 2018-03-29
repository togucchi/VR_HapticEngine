using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( menuName = "Haptic/HapticClip", fileName = "NewHapticClip" )]
public class HapticClip : ScriptableObject
{
	[Range(0, 5)]
	public float length = 0.1f;
	
	[Range(100, 1999)]
	public int min = 100;
	[Range(101, 2000)]
	public int max = 2000;
	public bool loop = false;

	public AnimationCurve curve;

	public int GetValueFromCurve(float time){
		int val = 0;
		int width = max - min;
		float pos = Mathf.Lerp(0f, 1f, time / length);
		Debug.Log("pos : " + pos);
		val = (int)(curve.Evaluate(pos) * width) + min;
		return val; 
	}
}