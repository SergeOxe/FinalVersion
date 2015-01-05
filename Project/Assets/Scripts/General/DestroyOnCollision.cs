using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour {
	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "enemy") {
			col.gameObject.GetComponent<enemyClass> ().DestroyThis ();
		} else
			Destroy (col.gameObject);
		}
}
