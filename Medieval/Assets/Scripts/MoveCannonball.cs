using UnityEngine;
using System.Collections;

public class MoveCannonball : MonoBehaviour {

	public float speed = 5;
	
	// Use this for initialization
	void Start () {

		Destroy (gameObject, 2);
		
	}


	// Update is called once per frame
	void Update () {
		transform.position = transform.position + -transform.forward * speed * Time.deltaTime ;
		
	}
}
