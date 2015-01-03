using UnityEngine;
using System.Collections;

public class openSceneScriptAnimation : MonoBehaviour {

	public AudioClip sleepingPenguin;
	public AudioClip sleepingBear;
	public AudioClip surprised;
	public AudioClip planes;
	public AudioClip bearEating;
	public AudioClip yellingPenguin;


	public void  playSleepingPenguinSound(){

		AudioSource.PlayClipAtPoint (sleepingPenguin, transform.position);
	}
	public void  playYellingPenguinSound(){
		AudioListener.volume = 0.5f;
		AudioSource.PlayClipAtPoint (yellingPenguin, transform.position);
	}

	public void PlaySleepingBearSound(){
		AudioSource.PlayClipAtPoint (sleepingBear, transform.position);
	}

	public void PlaySurprisedSound(){
		AudioSource.PlayClipAtPoint (surprised, transform.position);
	}
	public void PlayPlanesSound(){
		AudioSource.PlayClipAtPoint (planes, transform.position);
	}
	public void PlaybearEatingSound(){
		AudioSource.PlayClipAtPoint (bearEating, transform.position);
	}

}