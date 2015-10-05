using UnityEngine;
using System.Collections;

public class ShooterScript : MonoBehaviour {

	public GameObject Cannonball;
	public GameObject Muzzle ;
	public GameObject Smoke ;
	public float firstsp ;
	public float repeat ;
	
	// Use this for initialization
	void Start () {

		InvokeRepeating("shootAuto", firstsp, repeat);
		
	}
	
	// Update is called once per frame
	void Update () {


		}

		void shootAuto() {

		Instantiate(Cannonball, transform.position, transform.rotation);
		GetComponent<AudioSource>().Play();
		Instantiate(Muzzle, transform.position, transform.rotation);
		Instantiate (Smoke, transform.position, transform.rotation);
		}
	
	}