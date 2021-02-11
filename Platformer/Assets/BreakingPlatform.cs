using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingPlatform : MonoBehaviour {
	private bool isDebugging = false;
	private float destroyPlatformInterval = 3.0f;	// number of seconds to wait for platform destruction
	private void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Player") {
			if(isDebugging) print("Player interaction with platform.");
			Invoke("destroyPlatform", 1.0f);
		}	
	}

	private void destroyPlatform() {
		Destroy(this.gameObject);
	}
}
 