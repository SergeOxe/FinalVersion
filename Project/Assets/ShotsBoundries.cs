using UnityEngine;
using System.Collections;

public class ShotsBoundries : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "heroBullet") {
			Destroy(other.gameObject);
		}
	}

}
