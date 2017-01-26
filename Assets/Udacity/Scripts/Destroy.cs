using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	public GameObject objectToDestroy;
	public GameObject particleToCreate;
	public AudioSource coinSound;

	public void destroyObject () {
		Debug.Log ("My method was called");
		Object.Destroy (objectToDestroy, t: 0.2f);
		Object.Instantiate (particleToCreate, new Vector3 (objectToDestroy.transform.position.x, objectToDestroy.transform.position.y, objectToDestroy.transform.position.z), Quaternion.identity);
		coinSound.Play ();
	}
	

}




