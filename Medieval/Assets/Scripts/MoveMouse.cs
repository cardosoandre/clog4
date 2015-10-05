using UnityEngine;
using System.Collections;

public class MoveMouse : MonoBehaviour {

	private float speed = 50;

	public Color c1 = Color.yellow;
	public Color c2 = Color.red;
	public int lengthOfLineRenderer = 20;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.A)){
			transform.Translate(-Vector3.right * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.S)){
			transform.Translate(-Vector3.forward * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
		}

	}
}
