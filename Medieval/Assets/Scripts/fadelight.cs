using UnityEngine;
using System.Collections;

public class fadelight : MonoBehaviour {

	public float duration = 3.0F;
	public float originalRange;
	public Light lt;
	void Start() {
		lt = GetComponent<Light>();
		originalRange = lt.range;
	}
	void Update() {
		float amplitude = Mathf.PingPong(Time.time, duration);
		amplitude = amplitude / duration * 500;
		lt.range = originalRange * amplitude;
	}
}