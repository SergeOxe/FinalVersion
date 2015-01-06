using UnityEngine;
using System.Collections;

public class RandomColorOnInstatiate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Color NewColor =  new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f), 1f);
		//random color for Sprite.
		foreach (SpriteRenderer t in GetComponentsInChildren<SpriteRenderer> ()){
			t.color = NewColor;
		}
	}
}
