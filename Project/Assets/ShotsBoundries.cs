using UnityEngine;
using System.Collections;

public class ShotsBoundries : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "HeroBullet") {
			Destroy(other.gameObject);
		}
	}

}
