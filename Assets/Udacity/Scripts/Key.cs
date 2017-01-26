using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
	public GameObject key;
	public GameObject keyPoof;
	public Door door;
    //Create a reference to the KeyPoofPrefab and Door

	void Update()
	{
		//Bonus: Key Animation

			
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
		Object.Instantiate (keyPoof, new Vector3 (key.transform.position.x, key.transform.position.y, key.transform.position.z), Quaternion.identity);
        // Make sure the poof animates vertically

        // Call the Unlock() method on the Door
		door.Unlock();

        // Destroy the key. Check the Unity documentation on how to use Destroy
		Object.Destroy (key, t: 0.2f);
    }

}
