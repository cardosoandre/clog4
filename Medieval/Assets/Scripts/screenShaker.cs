using UnityEngine;
using System.Collections;

public class screenShaker : MonoBehaviour {

	public float shakeAmount = 2f;
	public float shakeTime = 1.5f;

	bool isShaking = false;
	private Vector3 originallocation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			StartCoroutine("shakeScreen");
		}	
		if (isShaking) {
			transform.position = originallocation + Random.insideUnitSphere * shakeAmount * Time.deltaTime;
		}	

	}

	IEnumerator shakeScreen() {
		isShaking = true;
		originallocation = transform.position;
		yield return new WaitForSeconds (shakeTime);
		isShaking = false;

	}

}
