﻿using UnityEngine;
using System.Collections;

public class Vanish : MonoBehaviour {

	public GameObject vanish;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
}

	void OnTriggerEnter(Collider other){ 
		Instantiate(vanish, transform.position, transform.rotation);
	}

}