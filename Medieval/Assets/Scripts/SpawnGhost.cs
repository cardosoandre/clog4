using UnityEngine;
using System.Collections;

public class SpawnGhost : MonoBehaviour {

	public GameObject Enemy;
	public float firstspawn;
	public float repeatspawn;

	// Use this for initialization
	void Start () {

		InvokeRepeating("EnemyAuto", firstspawn, repeatspawn);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void EnemyAuto() {
		
		Instantiate(Enemy, transform.position, transform.rotation);
	}
}
