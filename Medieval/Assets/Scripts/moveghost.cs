using UnityEngine;
using System.Collections;

public class moveghost : MonoBehaviour {

	public float speed;
	public GameObject vanish;
	public GameObject death;

	// Use this for initialization
	void Start () {

		Destroy (gameObject, 20);
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.LookAt (Vector3.zero);
		transform.position = transform.position + -transform.forward * speed * Time.deltaTime ;

	}

	void OnTriggerEnter(Collider other){ 
		if (other.gameObject.tag == "Finish") {
			Application.LoadLevel ("Scene 1 Medieval");
			print("die");
		}
		Destroy (gameObject);
		Instantiate (death, transform.position, transform.rotation);
		print ("hit");
	}

}
