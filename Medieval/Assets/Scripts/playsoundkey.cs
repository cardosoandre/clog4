using UnityEngine;
using System.Collections;

public class playsoundkey : MonoBehaviour {

	private AudioSource shoot_sound;

	// Use this for initialization
	void Start () {
		shoot_sound = gameObject.GetComponent<AudioSource>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A) && gameObject.GetComponent<AudioSource>().isPlaying == false) {
			shoot_sound.Play ();
		}
	
	}
}
