using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	//public GameObject door;
	// Create a boolean value called "locked" that can be checked in Update() 
	public bool unlocked;
	public bool notFullyRaised;

	void Start (){
		unlocked = false;
		notFullyRaised = true;
	}

	void Update() {
		// If the door is unlocked and it is not fully raised
		if(unlocked && notFullyRaised){
			// Animate the door raising up to y = 25
			if(transform.position.y <= 25f){
			transform.Translate (0, +2.5f * Time.deltaTime, 0, Space.World);
			//transform.Translate(transform.position.x, 25f, transform.position.z);
			}
		}
	}

	public void Unlock(){
		// You'll need to set "locked" to true here
		unlocked = true;
	}
}