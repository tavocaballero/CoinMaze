using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject poof;
	public GameObject objectToDestroy;


    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
		Object.Instantiate (poof, new Vector3 (objectToDestroy.transform.position.x, objectToDestroy.transform.position.y, objectToDestroy.transform.position.z), Quaternion.identity);
        // Make sure the poof animates vertically

        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Object.Destroy (objectToDestroy, t: 0.2f);
    }

}
