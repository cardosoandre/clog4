﻿using UnityEngine;
using System.Collections;

public class MoveMouse2 : MonoBehaviour {

	private float speed = 50;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate(-Vector3.right * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			transform.Translate(-Vector3.forward * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.UpArrow)){
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
	
	}
}
